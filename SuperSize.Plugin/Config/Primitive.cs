using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSize.Plugin.Config
{
    public class Primitive : IElement
    {

        public static readonly ImmutableArray<Type> AcceptedTypes = ImmutableArray.Create(new Type[]
        {
            typeof(string),
            typeof(int),
            typeof(float),
            typeof(bool),
        });

        public object? Value { get; }

        public Primitive(object? value)
        {
            // save if null
            if (value == null)
            {
                Value = value;
                return;
            }

            // check type next
            AcceptedTypes.IndexOf(value.GetType());
            Value = value;
        }

        public Primitive(string value)
        {
            Value = value;
        }

        public Primitive(int value)
        {
            Value = value;
        }

        public Primitive(float value)
        {
            Value = value;
        }

        public Primitive(bool value)
        {
            Value = value;
        }

        public Primitive()
        {
            Value = null;
        }

        public bool IsNull => Value == null;

        public T Get<T>() => Value != null ? (T)Value : FailNullCast<T>();

        public string GetString() => Get<string>();

        public int GetInt32() => Get<int>();

        public float GetSingle() => Get<float>();

        public bool GetBoolean() => Get<bool>();

        private static T FailNullCast<T>()
            => throw new InvalidCastException($"Couldn't cast primitive as {typeof(T)}. Is null.");
    }
}
