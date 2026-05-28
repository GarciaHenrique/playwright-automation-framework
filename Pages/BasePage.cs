using Microsoft.Playwright;

namespace PlaywrightFramework.Pages;

public class BasePage
{
    protected IPage Page;

    public BasePage(IPage page)
    {
        Page = page;
    }

    protected async Task Click(ILocator locator)
    {
        await locator.ClickAsync();
    }

    protected async Task Fill(ILocator locator, string text)
    {
        await locator.FillAsync(text);
    }

    protected async Task<string> GetText(ILocator locator)
    {
        return await locator.InnerTextAsync();
    }
}