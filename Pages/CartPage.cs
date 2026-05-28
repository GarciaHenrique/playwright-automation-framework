using Microsoft.Playwright;

namespace PlaywrightFramework.Pages;

public class CartPage
{
    private readonly IPage _page;

    public CartPage(IPage page)
    {
        _page = page;
    }

    // Locators
    private ILocator CheckoutButton =>
        _page.Locator("#checkout");

    private ILocator RemoveButton =>
        _page.Locator("#remove-sauce-labs-backpack");

    // Actions
    public async Task Checkout()
    {
        await CheckoutButton.ClickAsync();
    }

    public async Task RemoveProduct()
    {
        await RemoveButton.ClickAsync();
    }
}