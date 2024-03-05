using System;

namespace DtoGenerator.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class ExcludeProperty(params string[] classNames) : Attribute
{
    public string[] ClassNames { get; set; } = classNames;
}
