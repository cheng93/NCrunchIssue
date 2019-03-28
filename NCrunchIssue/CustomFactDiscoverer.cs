namespace NCrunchIssue
{
    using System.Collections.Generic;
    using Xunit.Abstractions;
    using Xunit.Sdk;

    public class CustomFactDiscoverer : IXunitTestCaseDiscoverer
    {
        private readonly IMessageSink diagnosticMessageSink;

        public CustomFactDiscoverer(IMessageSink diagnosticMessageSink)
        {
            this.diagnosticMessageSink = diagnosticMessageSink;
        }

        public IEnumerable<IXunitTestCase> Discover(ITestFrameworkDiscoveryOptions discoveryOptions, ITestMethod testMethod,
            IAttributeInfo factAttribute)
        {
            yield return new CustomTestCase(
                this.diagnosticMessageSink,
                discoveryOptions.MethodDisplayOrDefault(),
                discoveryOptions.MethodDisplayOptionsOrDefault(),
                testMethod);
        }
    }
}
