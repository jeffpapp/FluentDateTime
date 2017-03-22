using System;
using Xunit;

public class DateAssert
{
    public static void AreEqual(DateTime expected, DateTime actual, string message)
    {
        Assert.True(actual == expected && actual.Kind == expected.Kind, message);
    }

    public static void AreEqual(DateTime expected, DateTime actual)
    {
        AreEqual(expected, actual, null);
    }
}