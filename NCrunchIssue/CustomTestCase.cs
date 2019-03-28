namespace NCrunchIssue
{
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit.Abstractions;
    using Xunit.Sdk;

    public class CustomTestCase : XunitTestCase
    {
        public CustomTestCase() 
            : base()
        {
        }

        public CustomTestCase(
            IMessageSink diagnosticMessageSink,
            TestMethodDisplay defaultMethodDisplay,
            TestMethodDisplayOptions defaultMethodDisplayOptions,
            ITestMethod testMethod,
            object[] testMethodArguments = null)
            : base(diagnosticMessageSink, defaultMethodDisplay, defaultMethodDisplayOptions, testMethod, testMethodArguments)
        {
        }

        public override Task<RunSummary> RunAsync(
            IMessageSink diagnosticMessageSink,
            IMessageBus messageBus,
            object[] constructorArguments, 
            ExceptionAggregator aggregator,
            CancellationTokenSource cancellationTokenSource)
        {
            // Normally I would try and get a environment variable, and it would skip based on the value.
            // However for the purpose of this example, we will always skip.

            this.SkipReason = "Not running test. Wrong environment";

            return base.RunAsync(diagnosticMessageSink, messageBus, constructorArguments, aggregator, cancellationTokenSource);
        }
    }
}
