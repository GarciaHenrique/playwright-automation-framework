using Microsoft.Playwright;

namespace PlaywrightFramework.Pages;

public class CheckoutPage
{
    private readonly IPage _page;

    public CheckoutPage(IPage page)
    {
        _page = page;
    }

    // Locators
    private ILocator FirstNameInput =>
        _page.Locator("#first-name");

    private ILocator LastNameInput =>
        _page.Locator("#last-name");

    private ILocator PostalCodeInput =>
        _page.Locator("#postal-code");

    private ILocator ContinueButton =>
        _page.Locator("#continue");

    // Actions
    public async Task FillCheckoutForm(
        string firstName,
        string lastName,
        string postalCode)
    {
        await FirstNameInput.FillAsync(firstName);

        await LastNameInput.FillAsync(lastName);

        await PostalCodeInput.FillAsync(postalCode);

        await ContinueButton.ClickAsync();
    }
}