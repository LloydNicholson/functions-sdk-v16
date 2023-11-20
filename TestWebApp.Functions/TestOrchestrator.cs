namespace TestWebApp.Functions;

using Microsoft.DurableTask;

[DurableTask(nameof(TestOrchestrator))]
public class TestOrchestrator : TaskOrchestrator<string, string>
{
    public override Task<string> RunAsync(TaskOrchestrationContext ctx, string input) => Task.FromResult(string.Empty);
}
