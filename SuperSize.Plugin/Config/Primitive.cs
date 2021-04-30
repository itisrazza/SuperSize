using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSize.Plugin.Config
{
    /// <summary>
    /// Element primitives. May be <see cref="string"/>, <see cref="int"/>, <see cref="float"/> or <see cref="bool"/>.
    /// </summary>
    public class Primitive : IElement
    {

        /// <summary>
        /// Accepted primitive types.
        /// </summary>
        public static ImmutableArray<Type> AcceptedTypes { get; } = ImmutableArray.Create(new Type[]
        {
            typeof(string),
            typeof(int),
            typeof(float),
            typeof(bool),
        });

        /// <summary>
        /// Primitive value.
        /// </summary>
        public object? Value { get; }

        /// <summary>
        /// Creates a primitive value.
        /// </summary>
        /// <param name="value">Value to encapsulate.</param>
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

        /// <summary>
        /// Creates a primitive string.
        /// </summary>
        /// <param name="value">String to encapsulate.</param>
        public Primitive(string value)
        {
            Value = value;
        }

        /// <summary>
        /// Creates a primitive integer.
        /// </summary>
        /// <param name="value">Integer to encapsulate.</param>
        public Primitive(int value)
        {
            Value = value;
        }

        /// <summary>
        /// Creates a primitive number.
        /// </summary>
        /// <param name="value">Number to encapsulate.</param>
        public Primitive(float value)
        {
            Value = value;
        }

        /// <summary>
        /// Creates a primitive boolean.
        /// </summary>
        /// <param name="value">Boolean to encapsulate.</param>
        public Primitive(bool value)
        {
            Value = value;
        }

        /// <summary>
        /// Creates a null primitive.
        /// </summary>
        public Primitive()
        {
            Value = null;
        }

        /// <summary>
        /// Is this primitive null?
        /// </summary>
        public bool IsNull => Value == null;

        /// <summary>
        /// Get this value as cast it as a type.
        /// </summary>
        /// <typeparam name="T">Target type.</typeparam>
        /// <returns>Value as <typeparamref name="T"/></returns>
        public T Get<T>() => Value != null ? (T)Value : FailNullCast<T>();

        /// <summary>
        /// Get this value as a string.
        /// </summary>
        /// <returns>Value as string.</returns>
        public string GetString() => Get<string>();

        /// <summary>
        /// Get this value as an integer.
        /// </summary>
        /// <returns>Value as integer.</returns>
        public int GetInt32() => Get<int>();

        /// <summary>
        /// Get this value as a number.
        /// </summary>
        /// <returns>Value as floating-point number.</returns>
        public float GetSingle() => Get<float>();

        /// <summary>
        /// Get this value as a boolean.
        /// </summary>
        /// <returns>Value as boolean.</returns>
        public bool GetBoolean() => Get<bool>();

        /// <summary>
        /// Throw a null exception.
        /// </summary>
        private static T FailNullCast<T>()
            => throw new InvalidCastException($"Couldn't cast primitive as {typeof(T)}. Is null.");
    }
}
