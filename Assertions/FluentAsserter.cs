using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Assertions
{
  public class FluentAsserter
  {
    public async Task<FluentAsserter> ThrowsAsync<T>(string paramName, Func<System.Threading.Tasks.Task> testCode)
      where T : ArgumentException
    {
      await Assert.ThrowsAsync<T>(paramName, testCode);
      return this;
    }
    public FluentAsserter NotSame(object expected, object actual)
    {
      Assert.NotSame(expected, actual);
      return this;
    }
    public FluentAsserter Same(object expected, object actual)
    {
      Assert.Same(expected, actual);
      return this;
    }
    public FluentAsserter NotNull(object obj)
    {
      Assert.NotNull(obj);
      return this;
    }
    public FluentAsserter Null(object obj)
    {
      Assert.Null(obj);
      return this;
    }
    public FluentAsserter PropertyChanged(System.ComponentModel.INotifyPropertyChanged obj, string propertyName, System.Action testCode)
    {
      Assert.PropertyChanged(obj, propertyName, testCode);
      return this;
    }
    public async Task<FluentAsserter> PropertyChangedAsync(System.ComponentModel.INotifyPropertyChanged obj, string propertyName, Func<System.Threading.Tasks.Task> testCode)
    {
      await Assert.PropertyChangedAsync(obj, propertyName, testCode);
      return this;
    }
    public FluentAsserter InRange<T>(T actual, T low, T high)
      where T : IComparable
    {
      Assert.InRange<T>(actual, low, high);
      return this;
    }
    public FluentAsserter InRange<T>(T actual, T low, T high, IComparer<T> comparer)
      where T : IComparable
    {
      Assert.InRange<T>(actual, low, high, comparer);
      return this;
    }
    public FluentAsserter NotInRange<T>(T actual, T low, T high)
      where T : IComparable
    {
      Assert.NotInRange<T>(actual, low, high);
      return this;
    }
    public FluentAsserter NotInRange<T>(T actual, T low, T high, IComparer<T> comparer)
      where T : IComparable
    {
      Assert.NotInRange<T>(actual, low, high, comparer);
      return this;
    }
    public FluentAsserter ProperSubset<T>(ISet<T> expectedSuperset, ISet<T> actual)
    {
      Assert.ProperSubset<T>(expectedSuperset, actual);
      return this;
    }
    public FluentAsserter ProperSuperset<T>(ISet<T> expectedSubset, ISet<T> actual)
    {
      Assert.ProperSuperset<T>(expectedSubset, actual);
      return this;
    }
    public FluentAsserter Subset<T>(ISet<T> expectedSuperset, ISet<T> actual)
    {
      Assert.Subset<T>(expectedSuperset, actual);
      return this;
    }
    public FluentAsserter Superset<T>(ISet<T> expectedSubset, ISet<T> actual)
    {
      Assert.Superset<T>(expectedSubset, actual);
      return this;
    }
    public FluentAsserter Contains(string expectedSubstring, string actualString)
    {
      Assert.Contains(expectedSubstring, actualString);
      return this;
    }
    public FluentAsserter Contains(string expectedSubstring, string actualString, System.StringComparison comparisonType)
    {
      Assert.Contains(expectedSubstring, actualString, comparisonType);
      return this;
    }
    public FluentAsserter DoesNotContain(string expectedSubstring, string actualString)
    {
      Assert.DoesNotContain(expectedSubstring, actualString);
      return this;
    }
    public FluentAsserter DoesNotContain(string expectedSubstring, string actualString, System.StringComparison comparisonType)
    {
      Assert.DoesNotContain(expectedSubstring, actualString, comparisonType);
      return this;
    }
    public FluentAsserter StartsWith(string expectedStartString, string actualString)
    {
      Assert.StartsWith(expectedStartString, actualString);
      return this;
    }
    public FluentAsserter StartsWith(string expectedStartString, string actualString, System.StringComparison comparisonType)
    {
      Assert.StartsWith(expectedStartString, actualString, comparisonType);
      return this;
    }
    public FluentAsserter EndsWith(string expectedEndString, string actualString)
    {
      Assert.EndsWith(expectedEndString, actualString);
      return this;
    }
    public FluentAsserter EndsWith(string expectedEndString, string actualString, System.StringComparison comparisonType)
    {
      Assert.EndsWith(expectedEndString, actualString, comparisonType);
      return this;
    }
    public FluentAsserter Matches(string expectedRegexPattern, string actualString)
    {
      Assert.Matches(expectedRegexPattern, actualString);
      return this;
    }
    public FluentAsserter Matches(System.Text.RegularExpressions.Regex expectedRegex, string actualString)
    {
      Assert.Matches(expectedRegex, actualString);
      return this;
    }
    public FluentAsserter DoesNotMatch(string expectedRegexPattern, string actualString)
    {
      Assert.DoesNotMatch(expectedRegexPattern, actualString);
      return this;
    }
    public FluentAsserter DoesNotMatch(System.Text.RegularExpressions.Regex expectedRegex, string actualString)
    {
      Assert.DoesNotMatch(expectedRegex, actualString);
      return this;
    }
    public FluentAsserter Equal(string expected, string actual)
    {
      Assert.Equal(expected, actual);
      return this;
    }
    public FluentAsserter Equal(string expected, string actual, System.Boolean ignoreCase, System.Boolean ignoreLineEndingDifferences, System.Boolean ignoreWhiteSpaceDifferences)
    {
      Assert.Equal(expected, actual, ignoreCase, ignoreLineEndingDifferences, ignoreWhiteSpaceDifferences);
      return this;
    }
    public FluentAsserter IsAssignableFrom<T>(object obj)
    {
      Assert.IsAssignableFrom<T>(obj);
      return this;
    }
    public FluentAsserter IsAssignableFrom(System.Type expectedType, object obj)
    {
      Assert.IsAssignableFrom(expectedType, obj);
      return this;
    }
    public FluentAsserter IsNotType<T>(object obj)
    {
      Assert.IsNotType<T>(obj);
      return this;
    }
    public FluentAsserter IsNotType(System.Type expectedType, object obj)
    {
      Assert.IsNotType(expectedType, obj);
      return this;
    }
    public FluentAsserter IsType<T>(object obj)
    {
      Assert.IsType<T>(obj);
      return this;
    }
    public FluentAsserter IsType(System.Type expectedType, object obj)
    {
      Assert.IsType(expectedType, obj);
      return this;
    }
    public FluentAsserter False(System.Boolean condition)
    {
      Assert.False(condition);
      return this;
    }
    public FluentAsserter False(Boolean? condition)
    {
      Assert.False(condition);
      return this;
    }
    public FluentAsserter False(System.Boolean condition, string userMessage)
    {
      Assert.False(condition, userMessage);
      return this;
    }
    public FluentAsserter False(Boolean? condition, string userMessage)
    {
      Assert.False(condition, userMessage);
      return this;
    }
    public FluentAsserter True(System.Boolean condition)
    {
      Assert.True(condition);
      return this;
    }
    public FluentAsserter True(Boolean? condition)
    {
      Assert.True(condition);
      return this;
    }
    public FluentAsserter True(System.Boolean condition, string userMessage)
    {
      Assert.True(condition, userMessage);
      return this;
    }
    public FluentAsserter True(Boolean? condition, string userMessage)
    {
      Assert.True(condition, userMessage);
      return this;
    }
    public FluentAsserter All<T>(IEnumerable<T> collection, Action<T> action)
    {
      Assert.All<T>(collection, action);
      return this;
    }
    public FluentAsserter Collection<T>(IEnumerable<T> collection, Action<T>[] elementInspectors)
    {
      Assert.Collection<T>(collection, elementInspectors);
      return this;
    }
    public FluentAsserter Contains<T>(T expected, IEnumerable<T> collection)
    {
      Assert.Contains<T>(expected, collection);
      return this;
    }
    public FluentAsserter Contains<T>(T expected, IEnumerable<T> collection, IEqualityComparer<T> comparer)
    {
      Assert.Contains<T>(expected, collection, comparer);
      return this;
    }
    public FluentAsserter Contains<T>(IEnumerable<T> collection, Predicate<T> filter)
    {
      Assert.Contains<T>(collection, filter);
      return this;
    }
    public FluentAsserter DoesNotContain<T>(T expected, IEnumerable<T> collection)
    {
      Assert.DoesNotContain<T>(expected, collection);
      return this;
    }
    public FluentAsserter DoesNotContain<T>(T expected, IEnumerable<T> collection, IEqualityComparer<T> comparer)
    {
      Assert.DoesNotContain<T>(expected, collection, comparer);
      return this;
    }
    public FluentAsserter DoesNotContain<T>(IEnumerable<T> collection, Predicate<T> filter)
    {
      Assert.DoesNotContain<T>(collection, filter);
      return this;
    }
    public FluentAsserter Empty(System.Collections.IEnumerable collection)
    {
      Assert.Empty(collection);
      return this;
    }
    public FluentAsserter Equal<T>(IEnumerable<T> expected, IEnumerable<T> actual)
    {
      Assert.Equal<T>(expected, actual);
      return this;
    }
    public FluentAsserter Equal<T>(IEnumerable<T> expected, IEnumerable<T> actual, IEqualityComparer<T> comparer)
    {
      Assert.Equal<T>(expected, actual, comparer);
      return this;
    }
    public FluentAsserter NotEmpty(System.Collections.IEnumerable collection)
    {
      Assert.NotEmpty(collection);
      return this;
    }
    public FluentAsserter NotEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual)
    {
      Assert.NotEqual<T>(expected, actual);
      return this;
    }
    public FluentAsserter NotEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual, IEqualityComparer<T> comparer)
    {
      Assert.NotEqual<T>(expected, actual, comparer);
      return this;
    }
    public FluentAsserter Single(System.Collections.IEnumerable collection)
    {
      Assert.Single(collection);
      return this;
    }
    public FluentAsserter Single(System.Collections.IEnumerable collection, object expected)
    {
      Assert.Single(collection, expected);
      return this;
    }
    public FluentAsserter Single<T>(IEnumerable<T> collection)
    {
      Assert.Single<T>(collection);
      return this;
    }
    public FluentAsserter Single<T>(IEnumerable<T> collection, Predicate<T> predicate)
    {
      Assert.Single<T>(collection, predicate);
      return this;
    }
    public FluentAsserter Equal<T>(T expected, T actual)
    {
      Assert.Equal<T>(expected, actual);
      return this;
    }
    public FluentAsserter Equal<T>(T expected, T actual, IEqualityComparer<T> comparer)
    {
      Assert.Equal<T>(expected, actual, comparer);
      return this;
    }
    public FluentAsserter Equal(System.Double expected, System.Double actual, int precision)
    {
      Assert.Equal(expected, actual, precision);
      return this;
    }
    public FluentAsserter Equal(decimal expected, decimal actual, int precision)
    {
      Assert.Equal(expected, actual, precision);
      return this;
    }
    public FluentAsserter StrictEqual<T>(T expected, T actual)
    {
      Assert.StrictEqual<T>(expected, actual);
      return this;
    }
    public FluentAsserter NotEqual<T>(T expected, T actual)
    {
      Assert.NotEqual<T>(expected, actual);
      return this;
    }
    public FluentAsserter NotEqual<T>(T expected, T actual, IEqualityComparer<T> comparer)
    {
      Assert.NotEqual<T>(expected, actual, comparer);
      return this;
    }
    public FluentAsserter NotEqual(System.Double expected, System.Double actual, int precision)
    {
      Assert.NotEqual(expected, actual, precision);
      return this;
    }
    public FluentAsserter NotEqual(decimal expected, decimal actual, int precision)
    {
      Assert.NotEqual(expected, actual, precision);
      return this;
    }
    public FluentAsserter NotStrictEqual<T>(T expected, T actual)
    {
      Assert.NotStrictEqual<T>(expected, actual);
      return this;
    }
    public FluentAsserter Raises<T>(Action<EventHandler<T>> attach, Action<EventHandler<T>> detach, System.Action testCode)
      where T : EventArgs
    {
      Assert.Raises<T>(attach, detach, testCode);
      return this;
    }
    public FluentAsserter RaisesAny<T>(Action<EventHandler<T>> attach, Action<EventHandler<T>> detach, System.Action testCode)
      where T : EventArgs
    {
      Assert.RaisesAny<T>(attach, detach, testCode);
      return this;
    }
    public async Task<FluentAsserter> RaisesAsync<T>(Action<EventHandler<T>> attach, Action<EventHandler<T>> detach, Func<System.Threading.Tasks.Task> testCode)
      where T : EventArgs
    {
      await Assert.RaisesAsync<T>(attach, detach, testCode);
      return this;
    }
    public async Task<FluentAsserter> RaisesAnyAsync<T>(Action<EventHandler<T>> attach, Action<EventHandler<T>> detach, Func<System.Threading.Tasks.Task> testCode)
      where T : EventArgs
    {
      await Assert.RaisesAnyAsync<T>(attach, detach, testCode);
      return this;
    }
    public FluentAsserter Throws<T>(System.Action testCode)
      where T : Exception
    {
      Assert.Throws<T>(testCode);
      return this;
    }
    public FluentAsserter Throws<T>(Func<object> testCode)
      where T : Exception
    {
      Assert.Throws<T>(testCode);
      return this;
    }
    public async Task<FluentAsserter> ThrowsAsync<T>(Func<System.Threading.Tasks.Task> testCode)
      where T : Exception
    {
      await Assert.ThrowsAsync<T>(testCode);
      return this;
    }
    public FluentAsserter ThrowsAny<T>(System.Action testCode)
      where T : Exception
    {
      Assert.ThrowsAny<T>(testCode);
      return this;
    }
    public FluentAsserter ThrowsAny<T>(Func<object> testCode)
      where T : Exception
    {
      Assert.ThrowsAny<T>(testCode);
      return this;
    }
    public async Task<FluentAsserter> ThrowsAnyAsync<T>(Func<System.Threading.Tasks.Task> testCode)
      where T : Exception
    {
      await Assert.ThrowsAnyAsync<T>(testCode);
      return this;
    }
    public FluentAsserter Throws(System.Type exceptionType, System.Action testCode)
    {
      Assert.Throws(exceptionType, testCode);
      return this;
    }
    public FluentAsserter Throws(System.Type exceptionType, Func<object> testCode)
    {
      Assert.Throws(exceptionType, testCode);
      return this;
    }
    public async Task<FluentAsserter> ThrowsAsync(System.Type exceptionType, Func<System.Threading.Tasks.Task> testCode)
    {
      await Assert.ThrowsAsync(exceptionType, testCode);
      return this;
    }
    public FluentAsserter Throws<T>(string paramName, System.Action testCode)
      where T : ArgumentException
    {
      Assert.Throws<T>(paramName, testCode);
      return this;
    }
    public FluentAsserter Throws<T>(string paramName, Func<object> testCode)
      where T : ArgumentException
    {
      Assert.Throws<T>(paramName, testCode);
      return this;
    }

  }
}
