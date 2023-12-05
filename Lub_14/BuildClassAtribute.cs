using System;

namespace Lub_14
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class BuildClassAtribute : Attribute
    {
        public string Name { get; }
        public string Organization { get; }
        public BuildClassAtribute(string name, string organization)
        {
            Name = name;
            Organization = organization;
        }
    }
}
