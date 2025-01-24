using System;

namespace ITBees.Interfaces.CodeGeneration;

/// <summary>
/// Use this decorator if You want to have generated 'string?' types when using typescript generator  
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class NullableGuidPropertyAttribute : Attribute
{
}