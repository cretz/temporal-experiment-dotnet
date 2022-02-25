﻿using System;

namespace ReflectionAnalysisPoC
{
    class Attributes
    {
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = true, AllowMultiple = true)]
    public class WorkflowAttribute : Attribute
    {
        public string RunMethod { get; }

        public string WorkflowTypeName { get; set; }

        public WorkflowAttribute(string runMethod)
        {
            RunMethod = runMethod;
        }

        public override bool IsDefaultAttribute()
        {
            return false;
        }
    }

    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class WorkflowSignalAttribute : Attribute
    {
        public string SignalTypeName { get; }

        public WorkflowSignalAttribute()
            : this(String.Empty)
        {
        }

        public WorkflowSignalAttribute(string signalTypeName)
        {
            SignalTypeName = signalTypeName;
        }
    }

    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class WorkflowQueryAttribute : Attribute
    {
        public string QueryTypeName { get; }

        public WorkflowQueryAttribute()
            : this(String.Empty)
        {
        }

        public WorkflowQueryAttribute(string queryTypeName)
        {
            QueryTypeName = queryTypeName;
        }
    }
}
