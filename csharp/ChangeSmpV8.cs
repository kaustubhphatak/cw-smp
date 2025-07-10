using System;

namespace PhossSmp
{
    /// <summary>
    /// Marker attribute for future SMP V8 changes.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Constructor)]
    public sealed class ChangeSmpV8Attribute : Attribute
    {
        public string Value { get; }

        public ChangeSmpV8Attribute(string value = "")
        {
            Value = value;
        }
    }
}
