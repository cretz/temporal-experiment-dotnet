﻿using System;
using System.Threading.Tasks;
using Temporal.Common.DataModel;
using Temporal.WorkflowClient;

using static Temporal.Sdk.BasicSamples.Part1_4_TimersAndComposition2;

namespace Temporal.Sdk.BasicSamples
{
    public class Part2_1_ClientStartsAndUsesWorkflow
    {
        public static void Main(string[] args)
        {
            Minimal(args).GetAwaiter().GetResult();
            WorkflowMayAlreadyBeRunning(args).GetAwaiter().GetResult();
            AvoidLongPolls(args).GetAwaiter().GetResult();
            AccessResultOfWorkflowRun(args).GetAwaiter().GetResult();
            AccessResultOfEntireWorkflow(args).GetAwaiter().GetResult();
            UseSignalsAndQueries(args).GetAwaiter().GetResult();
            CancelCurrentWorkflowRunIfActive(args).GetAwaiter().GetResult();
        }

        public static async Task Minimal(string[] _)
        {
            TemporalServiceClientConfiguration serviceConfig = new();
            TemporalServiceNamespaceClient serviceClient = await (new TemporalServiceClient(serviceConfig)).GetNamespaceClientAsync();
            
            WorkflowRun workflowRun = await serviceClient.GetNewWorkflow("workflowTypeName").StartNewRunAsync("taskQueue");

            WorkflowRunResult result = await workflowRun.GetResultAsync();
            result.GetValue();
        }

        public static async Task WorkflowMayAlreadyBeRunning(string[] _)
        {
            TemporalServiceClientConfiguration serviceConfig = new();
            TemporalServiceClient serviceClient = new(serviceConfig);
            TemporalServiceNamespaceClient serviceNamespaceClient = await serviceClient.GetNamespaceClientAsync("namespace");

            Workflow workflowClient = await serviceNamespaceClient.GetWorkflowAsync("workflowTypeName", "workflowId");
            WorkflowRun workflowRun = await workflowClient.GetActiveOrStartNewRunAsync("taskQueue");

            WorkflowRunResult result = await workflowRun.GetResultAsync();
            result.GetValue();
        }

        public static async Task AvoidLongPolls(string[] _)
        {
            TemporalServiceClientConfiguration serviceConfig = new();
            TemporalServiceClient serviceClient = new(serviceConfig);
            TemporalServiceNamespaceClient serviceNamespaceClient = await serviceClient.GetNamespaceClientAsync("namespace");

            Workflow workflowClient = await serviceNamespaceClient.GetWorkflowAsync("workflowTypeName", "workflowId");
            WorkflowRun workflowRun = await workflowClient.GetActiveOrStartNewRunAsync("taskQueue");

            if ((await workflowRun.TryGetResultIfAvailableAync()).IsSuccess(out WorkflowRunResult result))
            {                                
                Console.WriteLine($"Workflow completed normally: {result.IsCompletedNormally}.");
            }
            
            Console.WriteLine($"Workflow did not yet complete. Doing some other works...");
            await Task.Delay(TimeSpan.FromSeconds(60));

            if ((await workflowRun.TryGetResultIfAvailableAync()).IsSuccess(out result))
            {
                Console.WriteLine($"Now workflow completed normally: {result.IsCompletedNormally}.");
            }

            Console.WriteLine($"Workflow still did not complete. Good bye.");
        }

        record ComputationResult(int Number) : IDataValue;        

        public static async Task AccessResultOfWorkflowRun(string[] _)
        {
            TemporalServiceClientConfiguration serviceConfig = new();
            TemporalServiceClient serviceClient = new(serviceConfig);
            TemporalServiceNamespaceClient serviceNamespaceClient = await serviceClient.GetNamespaceClientAsync("namespace");

            Workflow workflowClient = serviceNamespaceClient.GetNewWorkflow("ComputeSomeNumber");
            WorkflowRun workflowRun = await workflowClient.StartNewRunAsync("taskQueue");

            WorkflowRunResult<ComputationResult> result = await workflowRun.GetResultAsync<ComputationResult>();
            Console.WriteLine($"The result of the workflow is {result.GetValue().Number}.");            
        }

        public static async Task AccessResultOfEntireWorkflow(string[] _)
        {
            TemporalServiceClientConfiguration serviceConfig = new();
            TemporalServiceClient serviceClient = new(serviceConfig);
            TemporalServiceNamespaceClient serviceNamespaceClient = await serviceClient.GetNamespaceClientAsync("namespace");

            Workflow workflowClient = serviceNamespaceClient.GetNewWorkflow("ComputeSomeNumber");
            WorkflowRun workflowRun = await workflowClient.StartNewRunAsync("taskQueue");

            WorkflowRunResult<ComputationResult> result = await workflowRun.GetFinalWorkflowResultAsync<ComputationResult>();
            Console.WriteLine($"The result of the workflow, including all continue-as-new runs, is {result.GetValue().Number}.");
        }

         
        public static async Task UseSignalsAndQueries(string[] _)
        {
            TemporalServiceClientConfiguration serviceConfig = new();
            TemporalServiceClient serviceClient = new(serviceConfig);
            TemporalServiceNamespaceClient serviceNamespaceClient = await serviceClient.GetNamespaceClientAsync("namespace");
            Workflow workflowClient = serviceNamespaceClient.GetNewWorkflow("CountdownTimer");

            // Start countdown timer to finish in 1 min:            
            WorkflowRun workflowRun = await workflowClient.StartNewRunAsync("taskQueue",
                                                                            new TargetTimePayload(DateTime.UtcNow.AddMinutes(1)));

            // Do something else...
            await Task.Delay(TimeSpan.FromSeconds(30));

            // Push out target time by 30 secs:
            // Query the workflow, add a minute, signal workflow.
            TargetTimePayload prevTargetTime = await workflowRun.QueryAsync<TargetTimePayload>("GetCurrentTargetTimeUtc");
            TargetTimePayload newTargetTime = new(prevTargetTime.UtcDateTime.AddSeconds(30));
            await workflowRun.SignalAsync(RemoteApiNames.CountdownTimerWorkflow.Signals.UpdateTargetTime, newTargetTime);

            // Wait for the workflow to finish:
            CountdownResult result = (await workflowRun.GetResultAsync<CountdownResult>()).GetValue();
            Console.WriteLine($"The workflow {(result.IsTargetTimeReached ? "did" : "did not")} reach the target time.");
        }

        public static async Task CancelCurrentWorkflowRunIfActive(string[] _)
        {
            TemporalServiceClientConfiguration serviceConfig = new();
            TemporalServiceClient serviceClient = new(serviceConfig);
            TemporalServiceNamespaceClient serviceNamespaceClient = await serviceClient.GetNamespaceClientAsync("namespace");
             
            if ((await serviceNamespaceClient.TryGetExistingWorkflowAsync("workflowId")).IsSuccess(out Workflow workflowClient)
                    && (await workflowClient.TryGetLatestRunAsync()).IsSuccess(out WorkflowRun latestRun))
            {
                if (await latestRun.IsActiveAsync())
                {
                    // The Task returned by this API is completed when the cancellation request call is completed,
                    // i.e. the server persisted the request to cancel into the workflow history.
                    // We must await the completion of the workflow to learn when and whether the remote workflow
                    // honored the cancellation request.
                    await latestRun.RequestCancellationAsync();
                }

                // Wait for the workflow to finish and check if it respected the cancellation:
                // (note that if the workflow does not respect the cancellation, this may await indefinitely)
                WorkflowRunResult result = await latestRun.GetResultAsync();
                Console.WriteLine("Workflow cancellation "
                                + (result.IsCancelled ? "was respected" : "was not respected")
                                + " by the workflow.");
                return;
            }

            Console.WriteLine("Workflow not found or no run was active.");
        }
    }
}
