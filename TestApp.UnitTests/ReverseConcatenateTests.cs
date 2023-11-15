﻿using NUnit.Framework;

using System;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.Empty);
    }


    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
    // Arrange
    string[] input = { "god"};
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

    // Assert
    Assert.That(result, Is.EqualTo("god"));
    }

[Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
    // Arrange
    string[] input = { "god", "dog" };
    // Act
    string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

    // Assert
    Assert.That(result, Is.EqualTo("doggod"));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = null;
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        // Arrange
        string[] input = { "god ", " dog" };
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo(" doggod "));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
    // Arrange
    string[] input = { "god", "dog","cat" };
    // Act
    string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

    // Assert
    Assert.That(result, Is.EqualTo("catdoggod"));
    }
}
