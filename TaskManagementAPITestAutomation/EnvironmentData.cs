using NUnit.Framework;

namespace TaskManagementAPITestAutomation
{
    public static class EnvironmentData
    {
        public static string baseUrl { get; } = TestContext.Parameters["baseUrl"];
        public static string connectionString { get; } = TestContext.Parameters["connectionString"];
    }
}
