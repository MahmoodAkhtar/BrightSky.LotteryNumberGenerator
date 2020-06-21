using System;
using System.Collections.Generic;
using System.Linq;

namespace BrightSky.LotteryNumberGenerator.Cli2.Types
{
    public class YesNoArg
    {
        private static IReadOnlyList<string> _allowableNoArgValues = new[] { "n", "N" };
        private static IReadOnlyList<string> _allowableYesArgValues = new[] { "y", "Y" };

        public bool Value { get; }

        public YesNoArg(string arg)
        {
            if (IsValidYesArgValue(arg))
                Value = true;
            else if (IsValidNoArgValue(arg))
                Value = false;
            else // arg must be invalid
                throw new ArgumentOutOfRangeException(nameof(arg), $"Expecting {nameof(arg)} to be 'y', 'Y' or 'n', 'N'.");
        }

        private static bool IsValidNoArgValue(string arg)
            // "n", "N" then true;
            // also null, empty, whitespace (only) then true;
            => _allowableNoArgValues.Contains(arg.Trim()) || string.IsNullOrWhiteSpace(arg.Trim());

        private static bool IsValidYesArgValue(string arg)
            // "y", "Y" then true;
            => _allowableYesArgValues.Contains(arg.Trim());

        public static bool TryParse(string s, out YesNoArg yesNoArg)
        {
            if (IsValidYesArgValue(s) || IsValidNoArgValue(s))
            {
                yesNoArg = new YesNoArg(s);
                return true;
            }

            yesNoArg = new YesNoArg(_allowableNoArgValues[0]);
            return false;
        }
    }
}