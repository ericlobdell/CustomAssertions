using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Xunit.Sdk;

namespace Tests.Attributes
{
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
  [SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Justification = "This attribute is designed as an extensibility point.")]
  public class TimeoutAttribute : BeforeAfterTestAttribute
  {
    Dictionary<Type, object> _instances = new Dictionary<Type, object>();
    long _timeoutInMilliseconds;
    Stopwatch _timer;

    public TimeoutAttribute(long timeout)
    {
      _timeoutInMilliseconds = timeout;
      _timer = new Stopwatch();
      _timer.Start();
    }

    public override void Before(MethodInfo methodUnderTest)
    {
      var instance = GetTestClassInstance(methodUnderTest);
      var testParams = methodUnderTest.GetParameters();

      while (_timer.ElapsedMilliseconds < _timeoutInMilliseconds)
      {
        try
        {
          methodUnderTest.Invoke(instance, testParams);
          break;
        }
        catch (Exception) { }
      }
    }

    private object GetTestClassInstance(MethodInfo method)
    {
      var type = method.DeclaringType;

      if (_instances.ContainsKey(type))
        return _instances[type];
      else
      {
        var instance = Activator.CreateInstance(type);
        _instances.Add(type, instance);

        return instance;
      }
    }
  }
}
