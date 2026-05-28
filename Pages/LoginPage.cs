using Microsoft.Playwright;

namespace PlaywrightFramework.Pages;

public class LoginPage : BasePage
{
    private readonly IPage _page;

    public LoginPage(IPage page)
    : base(page)
    {
        _page = page;
    }

    // Locators
    private ILocator UsernameInput =>
        _page.Locator("#user-name");

    private ILocator PasswordInput =>
        _page.Locator("#password");

    private ILocator LoginButton =>
        _page.Locator("#login-button");

    private ILocator ErrorMessage =>
        _page.Locator("[data-test='error']");

    // Actions
    public async Task Login(
        string username,
        string password)
    {
        await Fill(UsernameInput, username);

        await Fill(PasswordInput, password);

        await Click(LoginButton);
    }

    // Validations
    public async Task<string> GetErrorMessage()
    {
        return await GetText(ErrorMessage);
    }
}