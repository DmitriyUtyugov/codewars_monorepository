using System;

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

[TestFixture]
public class KataTest
{
    [Test]
    public void FixedTests()
    {
        Assert.AreEqual("FFFFFF", Kata.Rgb(255, 255, 255));
        Assert.AreEqual("FFFFFF", Kata.Rgb(255, 255, 300));
        Assert.AreEqual("000000", Kata.Rgb(0, 0, 0));
        Assert.AreEqual("9400D3", Kata.Rgb(148, 0, 211));
        Assert.AreEqual("9400D3", Kata.Rgb(148, -20, 211), "Handle negative numbers.");
        Assert.AreEqual("90C3D4", Kata.Rgb(144, 195, 212));
        Assert.AreEqual("D4350C", Kata.Rgb(212, 53, 12), "Consider single hex digit numbers.");
    }
}