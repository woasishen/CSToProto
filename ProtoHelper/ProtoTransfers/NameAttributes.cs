using System;
using System.Reflection;
using Proto.Interfaces;
using Proto.ProtoInterface;

namespace Proto.ProtoTransfers
{
    public static class NameExtension
    {
        public static string GetNameStr(this Proto_ErrorIds errorId)
        {
            var fieldInfo = typeof(ErrorIds).GetField(errorId.ToString());
            return fieldInfo?.GetCustomAttribute<NameAttribute>()?.Name;
        }

        public static string GetNameStr(this Enum enumValue)
        {
            var type = enumValue.GetType();
            var fieldInfo = type.GetField(enumValue.ToString());
            return fieldInfo?.GetCustomAttribute<NameAttribute>()?.Name;
        }
    }

    public class NameAttribute : Attribute
    {
        public string Name { get; }
        public NameAttribute(string name)
        {
            Name = name;
        }
    }
}
