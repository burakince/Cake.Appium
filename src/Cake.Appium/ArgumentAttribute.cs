using System;

namespace Cake.Appium
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    public class ArgumentAttribute : Attribute
    {
        public string Name { get; set; }

        public ArgumentAttribute(string name)
        {
            Name = name;
        }
    }
}
