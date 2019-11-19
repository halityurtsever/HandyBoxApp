﻿using System.Globalization;

namespace HandyBoxApp.Utilities
{
    internal class Formatter
    {
        internal static string FormatCurrency(double value, Pad padding, int totalWidth)
        {
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(Constants.DefaultCultureCode);
            cultureInfo.NumberFormat.CurrencySymbol = Constants.DefaultCurrencyCode;
            cultureInfo.NumberFormat.CurrencyPositivePattern = 3;

            var result = string.Format(cultureInfo, Constants.Precision, value);

            return FormatString(result, padding, totalWidth);
        }

        internal static string FormatChangeRate(double value, Pad padding, int totalWidth)
        {
            var result = $"Change rate: %{value:F4}";

            return FormatString(result, padding, totalWidth);
        }

        internal static string FormatString(string value, Pad padding, int totalWidth, char paddingChar = Constants.DefaultPaddingChar)
        {
            if (padding == Pad.Right)
            {
                return value.PadRight(totalWidth, paddingChar);
            }

            return value.PadLeft(totalWidth, paddingChar);
        }
    }

    internal enum Pad
    {
        Left,
        Right
    }
}
