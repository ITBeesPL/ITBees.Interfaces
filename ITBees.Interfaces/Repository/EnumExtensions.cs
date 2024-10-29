using System;
using System.ComponentModel;
using System.Reflection;

namespace ITBees.Interfaces.Repository;

public static class EnumExtensions
{
    public static string GetDescription(this Enum value)
    {
        FieldInfo field = value.GetType().GetField(value.ToString());
        if (field != null)
        {
            DescriptionAttribute? attr = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            if (attr != null)
            {
                return attr.Description;
            }
        }
        return value.ToString();
    }
}