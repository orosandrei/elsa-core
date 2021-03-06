using Elsa.Activities.Console.Activities;
using Elsa.Expressions;
using Elsa.Services;
using Elsa.Services.Models;

namespace Sample14
{
    public class HelloWorldWorkflow : IWorkflow
    {
        public void Build(IWorkflowBuilder builder)
        {
            builder
                .StartWith<WriteLine>(activity => activity.TextExpression = new PlainTextExpression("Hello World!"));
        }
    }
}