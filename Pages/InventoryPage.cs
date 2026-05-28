using Microsoft.Playwright;

namespace PlaywrightFramework.Pages;

public class InventoryPage
{
    private readonly IPage _page;

    public InventoryPage(IPage page)
    {
        _page = page;
    }

    // Locators
    private ILocator BackpackAddButton =>
        _page.Locator("#add-to-cart-sauce-labs-backpack");

    private ILocator CartButton =>
        _page.Locator(".shopping_cart_link");

    // Actions
    public async Task AddBackpackToCart()
    {
        await BackpackAddButton.ClickAsync();
    }

    public async Task OpenCart()
    {
        await CartButton.ClickAsync();
    }
}