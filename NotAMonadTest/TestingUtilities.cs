﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

public static class TestingUtilities {
    public static void AssertTrue(this bool value) {
        Assert.IsTrue(value);
    }
    public static void AssertFalse(this bool value) {
        Assert.IsFalse(value);
    }
    public static void AssertEquals<T1, T2>(this T1 value1, T2 value2) {
        Assert.AreEqual(value1, value2);
    }
    public static void AssertNotEqualTo<T1, T2>(this T1 value1, T2 value2) {
        Assert.AreNotEqual(value1, value2);
    }
    public static void AssertThrows(Action action) {
        try {
            action();
        } catch (Exception) {
            return;
        }
        Assert.Fail("Expected method to throw, but it ran succesfully.");
    }
    public static void AssertThrows<T>(Func<T> action) {
        T result;
        try {
            result = action();
        } catch {
            return;
        }
        Assert.Fail("Expected method to throw, but it returned {0} instead.", result);
    }
    public static void AssertDoesNotThrow(Action action) {
        action();
    }
    public static void AssertDoesNotThrow<T>(Func<T> action) {
        action();
    }
}
