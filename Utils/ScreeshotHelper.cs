using Microsoft.Playwright;

namespace PlaywrightFramework.Utils;

public static class ScreenshotHelper
{
    public static async Task TakeScreenshot(
        IPage page,
        string fileName)
    {
        var directory = Path.Combine(
            Directory.GetCurrentDirectory(),
            "..",
            "..",
            "..",
            "Screenshots");

        Directory.CreateDirectory(directory);

        var path = Path.Combine(
            directory,
            $"{fileName}_{DateTime.Now:yyyyMMdd_HHmmss}.png");

        await page.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = path,
            FullPage = true
        });
    }
}