// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> JSON format file pattern. A property of JsonFormat. </summary>
    public readonly partial struct JsonFormatFilePattern : IEquatable<JsonFormatFilePattern>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="JsonFormatFilePattern"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JsonFormatFilePattern(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SetOfObjectsValue = "setOfObjects";
        private const string ArrayOfObjectsValue = "arrayOfObjects";

        /// <summary> setOfObjects. </summary>
        public static JsonFormatFilePattern SetOfObjects { get; } = new JsonFormatFilePattern(SetOfObjectsValue);
        /// <summary> arrayOfObjects. </summary>
        public static JsonFormatFilePattern ArrayOfObjects { get; } = new JsonFormatFilePattern(ArrayOfObjectsValue);
        /// <summary> Determines if two <see cref="JsonFormatFilePattern"/> values are the same. </summary>
        public static bool operator ==(JsonFormatFilePattern left, JsonFormatFilePattern right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JsonFormatFilePattern"/> values are not the same. </summary>
        public static bool operator !=(JsonFormatFilePattern left, JsonFormatFilePattern right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JsonFormatFilePattern"/>. </summary>
        public static implicit operator JsonFormatFilePattern(string value) => new JsonFormatFilePattern(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JsonFormatFilePattern other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JsonFormatFilePattern other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
