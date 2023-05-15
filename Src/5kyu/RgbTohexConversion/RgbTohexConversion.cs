using System;
using NUnit.Framework;

namespace RgbTohexConversion;

public class Kata
{
    public static string Rgb(int r, int g, int b)
    {
        (r, g, b) = NormalizeRgbValues(r, g, b);

        var hexadecimalString = $"{r:X2}{g:X2}{b:X2}";

        return hexadecimalString;
    }

    private static (int, int, int) NormalizeRgbValues(int r, int g, int b)
    {
        int upperBound = 255;
        int lowerBound = 0;

        r = Math.Max(
                Math.Min(upperBound, r),
                lowerBound
            );

        g = Math.Max(
                Math.Min(upperBound, g),
                lowerBound
            );

        b = Math.Max(
                Math.Min(upperBound, b),
                lowerBound
            );

        return (r, g, b);
    }
}