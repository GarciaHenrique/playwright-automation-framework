using Microsoft.Playwright;
using NUnit.Framework;
using PlaywrightFramework.Utils;

namespace PlaywrightFramework.Core;

public class BaseTest
{
    protected IPlaywright? Playwright;
    protected IBrowser? Browser;
    protected IBrowserContext? Context;
    protected IPage? Page;

    [SetUp]
    public async Task Setup()
    {
        Playwright = await Microsoft.Playwright.Playwright.CreateAsync();

        Browser = await Playwright.Chromium.LaunchAsync(
            new BrowserTypeLaunchOptions
            {
                Headless = true,
                SlowMo = 300
            });

        Context = await Browser.NewContextAsync(
            new BrowserNewContextOptions
            {
                RecordVideoDir = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "..",
                    "..",
                    "..",
                    "Videos"),

                ViewportSize = new ViewportSize
                {
                    Width = 1920,
                    Height = 1080
                }
            });

        Page = await Context.NewPageAsync();

        await Page.GotoAsync("https://www.saucedemo.com/");
    }

    [TearDown]
    public async Task TearDown()
    {
        var testStatus =
            TestContext.CurrentContext.Result.Outcome.Status;

        if (testStatus ==
            NUnit.Framework.Interfaces.TestStatus.Failed
            && Page != null)
        {
            await ScreenshotHelper.TakeScreenshot(
                Page,
                TestContext.CurrentContext.Test.Name);
        }

        if (Page != null)
        {
            await Page.CloseAsync();
        }

        if (Context != null)
        {
            await Context.CloseAsync();
        }

        if (Browser != null)
        {
            await Browser.CloseAsync();
        }

        Playwright?.Dispose();
    }
}