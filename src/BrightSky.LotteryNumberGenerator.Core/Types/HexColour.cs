using System;
using System.Text.RegularExpressions;

namespace BrightSky.LotteryNumberGenerator.Core.Types
{
    public class HexColour
    {
        private readonly Regex _regex = new Regex(@"^#(?:[0-9a-fA-F]{3}){1,2}$");

        public string Value { get; }

        public HexColour(string code)
        {
            if (!_regex.IsMatch(code))
                throw new ArgumentException($"{nameof(code)} is not a valid HEX colour code value.", $"{nameof(code)}");

            Value = code;
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            return obj is HexColour other
                && Value.ToLower() == other.Value.ToLower();
        }

        public override int GetHashCode()
            => Value.GetHashCode();

        public static bool operator ==(HexColour a, HexColour b)
        {
            if (a is null && b is null)
                return true;
            if (a is null || b is null)
                return false;
            return a.Equals(b);
        }

        public static bool operator !=(HexColour a, HexColour b)
            => !(a == b);

        public override string ToString()
            => Value;
    }
}