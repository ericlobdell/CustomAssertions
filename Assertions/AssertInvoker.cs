using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Assertions
{
  public class AssertInvoker
  {
    public async Task ThrowsAsync<T>(string paramName, Func<System.Threading.Tasks.Task> testCode)
  where T : ArgumentException
    {
      await Assert.ThrowsAsync<T>(paramName, testCode);
    }
    public void NotSame(object expected, object actual)
    {
      Assert.NotSame(expected, actual);
    }
    public void Same(object expected, object actual)
    {
      Assert.Same(expected, actual);
    }
    public void NotNull(object obj)
    {
      Assert.NotNull(obj);
    }
    public void Null(object obj)
    {
      Assert.Null(obj);
    }
    public void PropertyChanged(System.ComponentModel.INotifyPropertyChanged obj, string propertyName, System.Action testCode)
    {
      Assert.PropertyChanged(obj, propertyName, testCode);
    }
    public async Task PropertyChangedAsync(System.ComponentModel.INotifyPropertyChanged obj, string propertyName, Func<System.Threading.Tasks.Task> testCode)
    {
      await Assert.PropertyChangedAsync(obj, propertyName, testCode);
    }
    public void InRange<T>(T actual, T low, T high)
      where T : IComparable
    {
      Assert.InRange<T>(actual, low, high);
    }
    public void InRange<T>(T actual, T low, T high, IComparer<T> comparer)
      where T : IComparable
    {
      Assert.InRange<T>(actual, low, high, comparer);
    }
    public void NotInRange<T>(T actual, T low, T high)
      where T : IComparable
    {
      Assert.NotInRange<T>(actual, low, high);
    }
    public void NotInRange<T>(T actual, T low, T high, IComparer<T> comparer)
      where T : IComparable
    {
      Assert.NotInRange<T>(actual, low, high, comparer);
    }
    public void ProperSubset<T>(ISet<T> expectedSuperset, ISet<T> actual)
    {
      Assert.ProperSubset<T>(expectedSuperset, actual);
    }
    public void ProperSuperset<T>(ISet<T> expectedSubset, ISet<T> actual)
    {
      Assert.ProperSuperset<T>(expectedSubset, actual);
    }
    public void Subset<T>(ISet<T> expectedSuperset, ISet<T> actual)
    {
      Assert.Subset<T>(expectedSuperset, actual);
    }
    public void Superset<T>(ISet<T> expectedSubset, ISet<T> actual)
    {
      Assert.Superset<T>(expectedSubset, actual);
    }
    public void Contains(string expectedSubstring, string actualString)
    {
      Assert.Contains(expectedSubstring, actualString);
    }
    public void Contains(string expectedSubstring, string actualString, System.StringComparison comparisonType)
    {
      Assert.Contains(expectedSubstring, actualString, comparisonType);
    }
    public void DoesNotContain(string expectedSubstring, string actualString)
    {
      Assert.DoesNotContain(expectedSubstring, actualString);
    }
    public void DoesNotContain(string expectedSubstring, string actualString, System.StringComparison comparisonType)
    {
      Assert.DoesNotContain(expectedSubstring, actualString, comparisonType);
    }
    public void StartsWith(string expectedStartString, string actualString)
    {
      Assert.StartsWith(expectedStartString, actualString);
    }
    public void StartsWith(string expectedStartString, string actualString, System.StringComparison comparisonType)
    {
      Assert.StartsWith(expectedStartString, actualString, comparisonType);
    }
    public void EndsWith(string expectedEndString, string actualString)
    {
      Assert.EndsWith(expectedEndString, actualString);
    }
    public void EndsWith(string expectedEndString, string actualString, System.StringComparison comparisonType)
    {
      Assert.EndsWith(expectedEndString, actualString, comparisonType);
    }
    public void Matches(string expectedRegexPattern, string actualString)
    {
      Assert.Matches(expectedRegexPattern, actualString);
    }
    public void Matches(System.Text.RegularExpressions.Regex expectedRegex, string actualString)
    {
      Assert.Matches(expectedRegex, actualString);
    }
    public void DoesNotMatch(string expectedRegexPattern, string actualString)
    {
      Assert.DoesNotMatch(expectedRegexPattern, actualString);
    }
    public void DoesNotMatch(System.Text.RegularExpressions.Regex expectedRegex, string actualString)
    {
      Assert.DoesNotMatch(expectedRegex, actualString);
    }
    public void Equal(string expected, string actual)
    {
      Assert.Equal(expected, actual);
    }
    public void Equal(string expected, string actual, System.Boolean ignoreCase, System.Boolean ignoreLineEndingDifferences, System.Boolean ignoreWhiteSpaceDifferences)
    {
      Assert.Equal(expected, actual, ignoreCase, ignoreLineEndingDifferences, ignoreWhiteSpaceDifferences);
    }
    public void IsAssignableFrom<T>(object obj)
    {
      Assert.IsAssignableFrom<T>(obj);
    }
    public void IsAssignableFrom(System.Type expectedType, object obj)
    {
      Assert.IsAssignableFrom(expectedType, obj);
    }
    public void IsNotType<T>(object obj)
    {
      Assert.IsNotType<T>(obj);
    }
    public void IsNotType(System.Type expectedType, object obj)
    {
      Assert.IsNotType(expectedType, obj);
    }
    public void IsType<T>(object obj)
    {
      Assert.IsType<T>(obj);
    }
    public void IsType(System.Type expectedType, object obj)
    {
      Assert.IsType(expectedType, obj);
    }
    public void False(System.Boolean condition)
    {
      Assert.False(condition);
    }
    public void False(Boolean? condition)
    {
      Assert.False(condition);
    }
    public void False(System.Boolean condition, string userMessage)
    {
      Assert.False(condition, userMessage);
    }
    public void False(Boolean? condition, string userMessage)
    {
      Assert.False(condition, userMessage);
    }
    public void True(System.Boolean condition)
    {
      Assert.True(condition);
    }
    public void True(Boolean? condition)
    {
      Assert.True(condition);
    }
    public void True(System.Boolean condition, string userMessage)
    {
      Assert.True(condition, userMessage);
    }
    public void True(Boolean? condition, string userMessage)
    {
      Assert.True(condition, userMessage);
    }
    public void All<T>(IEnumerable<T> collection, Action<T> action)
    {
      Assert.All<T>(collection, action);
    }
    public void Collection<T>(IEnumerable<T> collection, Action<T>[] elementInspectors)
    {
      Assert.Collection<T>(collection, elementInspectors);
    }
    public void Contains<T>(T expected, IEnumerable<T> collection)
    {
      Assert.Contains<T>(expected, collection);
    }
    public void Contains<T>(T expected, IEnumerable<T> collection, IEqualityComparer<T> comparer)
    {
      Assert.Contains<T>(expected, collection, comparer);
    }
    public void Contains<T>(IEnumerable<T> collection, Predicate<T> filter)
    {
      Assert.Contains<T>(collection, filter);
    }
    public void DoesNotContain<T>(T expected, IEnumerable<T> collection)
    {
      Assert.DoesNotContain<T>(expected, collection);
    }
    public void DoesNotContain<T>(T expected, IEnumerable<T> collection, IEqualityComparer<T> comparer)
    {
      Assert.DoesNotContain<T>(expected, collection, comparer);
    }
    public void DoesNotContain<T>(IEnumerable<T> collection, Predicate<T> filter)
    {
      Assert.DoesNotContain<T>(collection, filter);
    }
    public void Empty(System.Collections.IEnumerable collection)
    {
      Assert.Empty(collection);
    }
    public void Equal<T>(IEnumerable<T> expected, IEnumerable<T> actual)
    {
      Assert.Equal<T>(expected, actual);
    }
    public void Equal<T>(IEnumerable<T> expected, IEnumerable<T> actual, IEqualityComparer<T> comparer)
    {
      Assert.Equal<T>(expected, actual, comparer);
    }
    public void NotEmpty(System.Collections.IEnumerable collection)
    {
      Assert.NotEmpty(collection);
    }
    public void NotEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual)
    {
      Assert.NotEqual<T>(expected, actual);
    }
    public void NotEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual, IEqualityComparer<T> comparer)
    {
      Assert.NotEqual<T>(expected, actual, comparer);
    }
    public void Single(System.Collections.IEnumerable collection)
    {
      Assert.Single(collection);
    }
    public void Single(System.Collections.IEnumerable collection, object expected)
    {
      Assert.Single(collection, expected);
    }
    public void Single<T>(IEnumerable<T> collection)
    {
      Assert.Single<T>(collection);
    }
    public void Single<T>(IEnumerable<T> collection, Predicate<T> predicate)
    {
      Assert.Single<T>(collection, predicate);
    }
    public void Equal<T>(T expected, T actual)
    {
      Assert.Equal<T>(expected, actual);
    }
    public void Equal<T>(T expected, T actual, IEqualityComparer<T> comparer)
    {
      Assert.Equal<T>(expected, actual, comparer);
    }
    public void Equal(System.Double expected, System.Double actual, int precision)
    {
      Assert.Equal(expected, actual, precision);
    }
    public void Equal(decimal expected, decimal actual, int precision)
    {
      Assert.Equal(expected, actual, precision);
    }
    public void StrictEqual<T>(T expected, T actual)
    {
      Assert.StrictEqual<T>(expected, actual);
    }
    public void NotEqual<T>(T expected, T actual)
    {
      Assert.NotEqual<T>(expected, actual);
    }
    public void NotEqual<T>(T expected, T actual, IEqualityComparer<T> comparer)
    {
      Assert.NotEqual<T>(expected, actual, comparer);
    }
    public void NotEqual(System.Double expected, System.Double actual, int precision)
    {
      Assert.NotEqual(expected, actual, precision);
    }
    public void NotEqual(decimal expected, decimal actual, int precision)
    {
      Assert.NotEqual(expected, actual, precision);
    }
    public void NotStrictEqual<T>(T expected, T actual)
    {
      Assert.NotStrictEqual<T>(expected, actual);
    }
    public void Raises<T>(Action<EventHandler<T>> attach, Action<EventHandler<T>> detach, System.Action testCode)
      where T : EventArgs
    {
      Assert.Raises<T>(attach, detach, testCode);
    }
    public void RaisesAny<T>(Action<EventHandler<T>> attach, Action<EventHandler<T>> detach, System.Action testCode)
      where T : EventArgs
    {
      Assert.RaisesAny<T>(attach, detach, testCode);
    }
    public async Task RaisesAsync<T>(Action<EventHandler<T>> attach, Action<EventHandler<T>> detach, Func<System.Threading.Tasks.Task> testCode)
      where T : EventArgs
    {
      await Assert.RaisesAsync<T>(attach, detach, testCode);
    }
    public async Task RaisesAnyAsync<T>(Action<EventHandler<T>> attach, Action<EventHandler<T>> detach, Func<System.Threading.Tasks.Task> testCode)
      where T : EventArgs
    {
      await Assert.RaisesAnyAsync<T>(attach, detach, testCode);
    }
    public void Throws<T>(System.Action testCode)
      where T : Exception
    {
      Assert.Throws<T>(testCode);
    }
    public void Throws<T>(Func<object> testCode)
      where T : Exception
    {
      Assert.Throws<T>(testCode);
    }
    public async Task ThrowsAsync<T>(Func<System.Threading.Tasks.Task> testCode)
      where T : Exception
    {
      await Assert.ThrowsAsync<T>(testCode);
    }
    public void ThrowsAny<T>(System.Action testCode)
      where T : Exception
    {
      Assert.ThrowsAny<T>(testCode);
    }
    public void ThrowsAny<T>(Func<object> testCode)
      where T : Exception
    {
      Assert.ThrowsAny<T>(testCode);
    }
    public async Task ThrowsAnyAsync<T>(Func<System.Threading.Tasks.Task> testCode)
      where T : Exception
    {
      await Assert.ThrowsAnyAsync<T>(testCode);
    }
    public void Throws(System.Type exceptionType, System.Action testCode)
    {
      Assert.Throws(exceptionType, testCode);
    }
    public void Throws(System.Type exceptionType, Func<object> testCode)
    {
      Assert.Throws(exceptionType, testCode);
    }
    public async Task ThrowsAsync(System.Type exceptionType, Func<System.Threading.Tasks.Task> testCode)
    {
      await Assert.ThrowsAsync(exceptionType, testCode);
    }
    public void Throws<T>(string paramName, System.Action testCode)
      where T : ArgumentException
    {
      Assert.Throws<T>(paramName, testCode);
    }
    public void Throws<T>(string paramName, Func<object> testCode)
      where T : ArgumentException
    {
      Assert.Throws<T>(paramName, testCode);
    }
  }
}
