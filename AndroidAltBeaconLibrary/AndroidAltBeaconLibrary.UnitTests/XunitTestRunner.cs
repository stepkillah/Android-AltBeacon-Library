using System.Reflection;
using Xunit;
using Xunit.Abstractions;

namespace AndroidAltBeaconLibrary.UnitTests;

public class XunitTestRunner
{
    public string RunTests()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var task = RunAsync(assembly);
        var results = task.GetAwaiter().GetResult();

        var output = new System.Text.StringBuilder();
        output.AppendLine($"Test Results:");
        output.AppendLine($"Total: {results.Total}");
        output.AppendLine($"Passed: {results.Passed}");
        output.AppendLine($"Failed: {results.Failed}");
        output.AppendLine($"Skipped: {results.Skipped}");

        if (results.Failures.Any())
        {
            output.AppendLine("\nFailures:");
            foreach (var failure in results.Failures)
            {
                output.AppendLine($"- {failure.TestDisplayName}: {failure.ExceptionMessage}");
            }
        }

        return output.ToString();
    }

    public async Task<TestResults> RunAsync(Assembly assembly)
    {
        var results = new TestResults();

        // Find all test classes
        var testClasses = assembly.GetTypes()
            .Where(t => t.GetMethods().Any(m => m.GetCustomAttribute<FactAttribute>() != null))
            .ToList();

        foreach (var testClass in testClasses)
        {
            var instance = Activator.CreateInstance(testClass);

            var testMethods = testClass.GetMethods()
                .Where(m => m.GetCustomAttribute<FactAttribute>() != null)
                .ToList();

            foreach (var testMethod in testMethods)
            {
                results.Total++;

                try
                {
                    var result = testMethod.Invoke(instance, null);

                    // Handle async methods
                    if (result is Task task)
                    {
                        await task;
                    }

                    results.Passed++;
                }
                catch (Exception ex)
                {
                    results.Failed++;
                    results.Failures.Add(new TestFailure
                    {
                        TestDisplayName = $"{testClass.Name}.{testMethod.Name}",
                        ExceptionMessage = ex.InnerException?.Message ?? ex.Message
                    });
                }
            }
        }

        return results;
    }
}

public class TestResults
{
    public int Total { get; set; }
    public int Passed { get; set; }
    public int Failed { get; set; }
    public int Skipped { get; set; }
    public List<TestFailure> Failures { get; set; } = new();
}

public class TestFailure
{
    public string TestDisplayName { get; set; } = "";
    public string ExceptionMessage { get; set; } = "";
}