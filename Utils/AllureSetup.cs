namespace PlaywrightFramework.Utils;

public static class AllureSetup
{
    public static void Configure()
    {
        Environment.SetEnvironmentVariable(
            "ALLURE_CONFIG",
            Path.Combine(
                Directory.GetCurrentDirectory(),
                "..",
                "..",
                "..",
                "allureConfig.json"));
    }
}