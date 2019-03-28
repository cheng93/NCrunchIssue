namespace NCrunchIssue
{
    using Xunit;
    using Xunit.Sdk;

    [XunitTestCaseDiscoverer("NCrunchIssue.CustomFactDiscoverer", "NCrunchIssue")]
    public class CustomFactAttribute : FactAttribute
    {
    }
}
