namespace PlaywrightFramework.Utils;

public static class AllureResultsHelper
{
    public static void MoveResultsToRoot()
    {
        var source = Path.Combine(
            Directory.GetCurrentDirectory(),
            "allure-results");

        var destination = Path.Combine(
            Directory.GetCurrentDirectory(),
            "..",
            "..",
            "..",
            "allure-results");

        if (!Directory.Exists(source))
            return;

        Directory.CreateDirectory(destination);

        foreach (var file in Directory.GetFiles(source))
        {
            var fileName = Path.GetFileName(file);

            var destFile = Path.Combine(destination, fileName);

            File.Copy(file, destFile, true);
        }
    }
}