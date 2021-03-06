﻿using DevelApp.Utility.Exceptions;
using System;
using System.Collections.Generic;

namespace DevelApp.Utility.Model
{
    public sealed class KeyString : IEquatable<KeyString>
    {
        private static int MAX_KEY_LENGTH = 100;
        private string _innerKeyString;

        public KeyString()
        {
            _innerKeyString = string.Empty;
        }

        public KeyString(string keyString)
        {
            ValidateString(keyString);
            _innerKeyString = keyString;
        }

        /// <summary>
        /// Throw exceptions if format is not proper
        /// </summary>
        /// <param name="keyString"></param>
        private void ValidateString(string keyString)
        {
            if (keyString.Length > MAX_KEY_LENGTH)
            {
                throw new KeyStringException($"KeyString is above the allowed {MAX_KEY_LENGTH}");
            }
        }

        /// <summary>
        /// Serialization property that might change as interface so please do not use
        /// </summary>
        public string InnerString
        {
            get
            {
                return _innerKeyString;
            }
            set
            {
                ValidateString(value);
                _innerKeyString = value;
            }
        }

        public KeyString Clone()
        {
            return new KeyString(_innerKeyString);
        }

        public bool Equals(KeyString other)
        {
            return _innerKeyString.Equals(other.ToString());
        }

        public bool Equals(string other)
        {
            return _innerKeyString.Equals(other);
        }

        public override string ToString()
        {
            return _innerKeyString;
        }

        public override int GetHashCode()
        {
            return -2062801960 + EqualityComparer<string>.Default.GetHashCode(_innerKeyString);
        }

        #region Implicit operators

        public static implicit operator KeyString(string rhs)
        {
            return new KeyString(rhs);
        }

        public static implicit operator string(KeyString rhs)
        {
            return rhs.ToString();
        }

        #endregion
    }
}
