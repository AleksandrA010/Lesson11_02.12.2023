using System;

namespace Lub_14
{
    internal class DeveloperInfoAttribute : Attribute
    {
        public string Name { get; }
        public DateTime DateTimeCreate { get; }
        public DeveloperInfoAttribute(string name)
        {
            Name = name;
            DateTimeCreate = new DateTime(2023, 12, 5);
        }
    }
}
