using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Assertions
{
  public class AssertInvoker
  {
    public async Task<AssertInvoker> ThrowsAsync<T>(string paramName, Func<System.Threading.Tasks.Task> testCode)
      where T : ArgumentException
    {
      await Assert.ThrowsAsync<T>(paramName, testCode);
      return this;
    }
    public AssertInvoker NotSame(object expected, object actual)
    {
      Assert.NotSame(expected, actual);
      return this;
    }
    public AssertInvoker Same(object expected, object actual)
    {
      Assert.Same(expected, actual);
      return this;
    }
    public AssertInvoker NotNull(object obj)
    {
      Assert.NotNull(obj);
      return this;
    }
    public AssertInvoker Null(object obj)
    {
      Assert.Null(obj);
      return this;
    }
    public AssertInvoker PropertyChanged(System.ComponentModel.INotifyPropertyChanged obj, string propertyName, System.Action testCode)
    {
      Assert.PropertyChanged(obj, propertyName, testCode);
      return this;
    }
    public async Task<AssertInvoker> PropertyChangedAsync(System.ComponentModel.INotifyPropertyChanged obj, string propertyName, Func<System.Threading.Tasks.Task> testCode)
    {
      await Assert.PropertyChangedAsync(obj, propertyName, testCode);
      return this;
    }
    public AssertInvoker InRange<T>(T actual, T low, T high)
      where T : IComparable
    {
      Assert.InRange<T>(actual, low, high);
      return this;
    }
    public AssertInvoker InRange<T>(T actual, T low, T high, IComparer<T> comparer)
      where T : IComparable
    {
      Assert.InRange<T>(actual, low, high, comparer);
      return this;
    }
    public AssertInvoker NotInRange<T>(T actual, T low, T high)
      where T : IComparable
    {
      Assert.NotInRange<T>(actual, low, high);
      return this;
    }
    public AssertInvoker NotInRange<T>(T actual, T low, T high, IComparer<T> comparer)
      where T : IComparable
    {
      Assert.NotInRange<T>(actual, low, high, comparer);
      return this;
    }
    public AssertInvoker ProperSubset<T>(ISet<T> expectedSuperset, ISet<T> actual)
    {
      Assert.ProperSubset<T>(expectedSuperset, actual);
      return this;
    }
    public AssertInvoker ProperSuperset<T>(ISet<T> expectedSubset, ISet<T> actual)
    {
      Assert.ProperSuperset<T>(expectedSubset, actual);
      return this;
    }
    public AssertInvoker Subset<T>(ISet<T> expectedSuperset, ISet<T> actual)
    {
      Assert.Subset<T>(expectedSuperset, actual);
      return this;
    }
    public AssertInvoker Superset<T>(ISet<T> expectedSubset, ISet<T> actual)
    {
      Assert.Superset<T>(expectedSubset, actual);
      return this;
    }
    public AssertInvoker Contains(string expectedSubstring, string actualString)
    {
      Assert.Contains(expectedSubstring, actualString);
      return this;
    }
    public AssertInvoker Contains(string expectedSubstring, string actualString, System.StringComparison comparisonType)
    {
      Assert.Contains(expectedSubstring, actualString, comparisonType);
      return this;
    }
    public AssertInvoker DoesNotContain(string expectedSubstring, string actualString)
    {
      Assert.DoesNotContain(expectedSubstring, actualString);
      return this;
    }
    public AssertInvoker DoesNotContain(string expectedSubstring, string actualString, System.StringComparison comparisonType)
    {
      Assert.DoesNotContain(expectedSubstring, actualString, comparisonType);
      return this;
    }
    public AssertInvoker StartsWith(string expectedStartString, string actualString)
    {
      Assert.StartsWith(expectedStartString, actualString);
      return this;
    }
    public AssertInvoker StartsWith(string expectedStartString, string actualString, System.StringComparison comparisonType)
    {
      Assert.StartsWith(expectedStartString, actualString, comparisonType);
      return this;
    }
    public AssertInvoker EndsWith(string expectedEndString, string actualString)
    {
      Assert.EndsWith(expectedEndString, actualString);
      return this;
    }
    public AssertInvoker EndsWith(string expectedEndString, string actualString, System.StringComparison comparisonType)
    {
      Assert.EndsWith(expectedEndString, actualString, comparisonType);
      return this;
    }
    public AssertInvoker Matches(string expectedRegexPattern, string actualString)
    {
      Assert.Matches(expectedRegexPattern, actualString);
      return this;
    }
    public AssertInvoker Matches(System.Text.RegularExpressions.Regex expectedRegex, string actualString)
    {
      Assert.Matches(expectedRegex, actualString);
      return this;
    }
    public AssertInvoker DoesNotMatch(string expectedRegexPattern, string actualString)
    {
      Assert.DoesNotMatch(expectedRegexPattern, actualString);
      return this;
    }
    public AssertInvoker DoesNotMatch(System.Text.RegularExpressions.Regex expectedRegex, string actualString)
    {
      Assert.DoesNotMatch(expectedRegex, actualString);
      return this;
    }
    public AssertInvoker Equal(string expected, string actual)
    {
      Assert.Equal(expected, actual);
      return this;
    }
    public AssertInvoker Equal(string expected, string actual, System.Boolean ignoreCase, System.Boolean ignoreLineEndingDifferences, System.Boolean ignoreWhiteSpaceDifferences)
    {
      Assert.Equal(expected, actual, ignoreCase, ignoreLineEndingDifferences, ignoreWhiteSpaceDifferences);
      return this;
    }
    public AssertInvoker IsAssignableFrom<T>(object obj)
    {
      Assert.IsAssignableFrom<T>(obj);
      return this;
    }
    public AssertInvoker IsAssignableFrom(System.Type expectedType, object obj)
    {
      Assert.IsAssignableFrom(expectedType, obj);
      return this;
    }
    public AssertInvoker IsNotType<T>(object obj)
    {
      Assert.IsNotType<T>(obj);
      return this;
    }
    public AssertInvoker IsNotType(System.Type expectedType, object obj)
    {
      Assert.IsNotType(expectedType, obj);
      return this;
    }
    public AssertInvoker IsType<T>(object obj)
    {
      Assert.IsType<T>(obj);
      return this;
    }
    public AssertInvoker IsType(System.Type expectedType, object obj)
    {
      Assert.IsType(expectedType, obj);
      return this;
    }
    public AssertInvoker False(System.Boolean condition)
    {
      Assert.False(condition);
      return this;
    }
    public AssertInvoker False(Boolean? condition)
    {
      Assert.False(condition);
      return this;
    }
    public AssertInvoker False(System.Boolean condition, string userMessage)
    {
      Assert.False(condition, userMessage);
      return this;
    }
    public AssertInvoker False(Boolean? condition, string userMessage)
    {
      Assert.False(condition, userMessage);
      return this;
    }
    public AssertInvoker True(System.Boolean condition)
    {
      Assert.True(condition);
      return this;
    }
    public AssertInvoker True(Boolean? condition)
    {
      Assert.True(condition);
      return this;
    }
    public AssertInvoker True(System.Boolean condition, string userMessage)
    {
      Assert.True(condition, userMessage);
      return this;
    }
    public AssertInvoker True(Boolean? condition, string userMessage)
    {
      Assert.True(condition, userMessage);
      return this;
    }
    public AssertInvoker All<T>(IEnumerable<T> collection, Action<T> action)
    {
      Assert.All<T>(collection, action);
      return this;
    }
    public AssertInvoker Collection<T>(IEnumerable<T> collection, Action<T>[] elementInspectors)
    {
      Assert.Collection<T>(collection, elementInspectors);
      return this;
    }
    public AssertInvoker Contains<T>(T expected, IEnumerable<T> collection)
    {
      Assert.Contains<T>(expected, collection);
      return this;
    }
    public AssertInvoker Contains<T>(T expected, IEnumerable<T> collection, IEqualityComparer<T> comparer)
    {
      Assert.Contains<T>(expected, collection, comparer);
      return this;
    }
    public AssertInvoker Contains<T>(IEnumerable<T> collection, Predicate<T> filter)
    {
      Assert.Contains<T>(collection, filter);
      return this;
    }
    public AssertInvoker DoesNotContain<T>(T expected, IEnumerable<T> collection)
    {
      Assert.DoesNotContain<T>(expected, collection);
      return this;
    }
    public AssertInvoker DoesNotContain<T>(T expected, IEnumerable<T> collection, IEqualityComparer<T> comparer)
    {
      Assert.DoesNotContain<T>(expected, collection, comparer);
      return this;
    }
    public AssertInvoker DoesNotContain<T>(IEnumerable<T> collection, Predicate<T> filter)
    {
      Assert.DoesNotContain<T>(collection, filter);
      return this;
    }
    public AssertInvoker Empty(System.Collections.IEnumerable collection)
    {
      Assert.Empty(collection);
      return this;
    }
    public AssertInvoker Equal<T>(IEnumerable<T> expected, IEnumerable<T> actual)
    {
      Assert.Equal<T>(expected, actual);
      return this;
    }
    public AssertInvoker Equal<T>(IEnumerable<T> expected, IEnumerable<T> actual, IEqualityComparer<T> comparer)
    {
      Assert.Equal<T>(expected, actual, comparer);
      return this;
    }
    public AssertInvoker NotEmpty(System.Collections.IEnumerable collection)
    {
      Assert.NotEmpty(collection);
      return this;
    }
    public AssertInvoker NotEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual)
    {
      Assert.NotEqual<T>(expected, actual);
      return this;
    }
    public AssertInvoker NotEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual, IEqualityComparer<T> comparer)
    {
      Assert.NotEqual<T>(expected, actual, comparer);
      return this;
    }
    public AssertInvoker Single(System.Collections.IEnumerable collection)
    {
      Assert.Single(collection);
      return this;
    }
    public AssertInvoker Single(System.Collections.IEnumerable collection, object expected)
    {
      Assert.Single(collection, expected);
      return this;
    }
    public AssertInvoker Single<T>(IEnumerable<T> collection)
    {
      Assert.Single<T>(collection);
      return this;
    }
    public AssertInvoker Single<T>(IEnumerable<T> collection, Predicate<T> predicate)
    {
      Assert.Single<T>(collection, predicate);
      return this;
    }
    public AssertInvoker Equal<T>(T expected, T actual)
    {
      Assert.Equal<T>(expected, actual);
      return this;
    }
    public AssertInvoker Equal<T>(T expected, T actual, IEqualityComparer<T> comparer)
    {
      Assert.Equal<T>(expected, actual, comparer);
      return this;
    }
    public AssertInvoker Equal(System.Double expected, System.Double actual, int precision)
    {
      Assert.Equal(expected, actual, precision);
      return this;
    }
    public AssertInvoker Equal(decimal expected, decimal actual, int precision)
    {
      Assert.Equal(expected, actual, precision);
      return this;
    }
    public AssertInvoker StrictEqual<T>(T expected, T actual)
    {
      Assert.StrictEqual<T>(expected, actual);
      return this;
    }
    public AssertInvoker NotEqual<T>(T expected, T actual)
    {
      Assert.NotEqual<T>(expected, actual);
      return this;
    }
    public AssertInvoker NotEqual<T>(T expected, T actual, IEqualityComparer<T> comparer)
    {
      Assert.NotEqual<T>(expected, actual, comparer);
      return this;
    }
    public AssertInvoker NotEqual(System.Double expected, System.Double actual, int precision)
    {
      Assert.NotEqual(expected, actual, precision);
      return this;
    }
    public AssertInvoker NotEqual(decimal expected, decimal actual, int precision)
    {
      Assert.NotEqual(expected, actual, precision);
      return this;
    }
    public AssertInvoker NotStrictEqual<T>(T expected, T actual)
    {
      Assert.NotStrictEqual<T>(expected, actual);
      return this;
    }
    public AssertInvoker Raises<T>(Action<EventHandler<T>> attach, Action<EventHandler<T>> detach, System.Action testCode)
      where T : EventArgs
    {
      Assert.Raises<T>(attach, detach, testCode);
      return this;
    }
    public AssertInvoker RaisesAny<T>(Action<EventHandler<T>> attach, Action<EventHandler<T>> detach, System.Action testCode)
      where T : EventArgs
    {
      Assert.RaisesAny<T>(attach, detach, testCode);
      return this;
    }
    public async Task<AssertInvoker> RaisesAsync<T>(Action<EventHandler<T>> attach, Action<EventHandler<T>> detach, Func<System.Threading.Tasks.Task> testCode)
      where T : EventArgs
    {
      await Assert.RaisesAsync<T>(attach, detach, testCode);
      return this;
    }
    public async Task<AssertInvoker> RaisesAnyAsync<T>(Action<EventHandler<T>> attach, Action<EventHandler<T>> detach, Func<System.Threading.Tasks.Task> testCode)
      where T : EventArgs
    {
      await Assert.RaisesAnyAsync<T>(attach, detach, testCode);
      return this;
    }
    public AssertInvoker Throws<T>(System.Action testCode)
      where T : Exception
    {
      Assert.Throws<T>(testCode);
      return this;
    }
    public AssertInvoker Throws<T>(Func<object> testCode)
      where T : Exception
    {
      Assert.Throws<T>(testCode);
      return this;
    }
    public async Task<AssertInvoker> ThrowsAsync<T>(Func<System.Threading.Tasks.Task> testCode)
      where T : Exception
    {
      await Assert.ThrowsAsync<T>(testCode);
      return this;
    }
    public AssertInvoker ThrowsAny<T>(System.Action testCode)
      where T : Exception
    {
      Assert.ThrowsAny<T>(testCode);
      return this;
    }
    public AssertInvoker ThrowsAny<T>(Func<object> testCode)
      where T : Exception
    {
      Assert.ThrowsAny<T>(testCode);
      return this;
    }
    public async Task<AssertInvoker> ThrowsAnyAsync<T>(Func<System.Threading.Tasks.Task> testCode)
      where T : Exception
    {
      await Assert.ThrowsAnyAsync<T>(testCode);
      return this;
    }
    public AssertInvoker Throws(System.Type exceptionType, System.Action testCode)
    {
      Assert.Throws(exceptionType, testCode);
      return this;
    }
    public AssertInvoker Throws(System.Type exceptionType, Func<object> testCode)
    {
      Assert.Throws(exceptionType, testCode);
      return this;
    }
    public async Task<AssertInvoker> ThrowsAsync(System.Type exceptionType, Func<System.Threading.Tasks.Task> testCode)
    {
      await Assert.ThrowsAsync(exceptionType, testCode);
      return this;
    }
    public AssertInvoker Throws<T>(string paramName, System.Action testCode)
      where T : ArgumentException
    {
      Assert.Throws<T>(paramName, testCode);
      return this;
    }
    public AssertInvoker Throws<T>(string paramName, Func<object> testCode)
      where T : ArgumentException
    {
      Assert.Throws<T>(paramName, testCode);
      return this;
    }


  }
}
