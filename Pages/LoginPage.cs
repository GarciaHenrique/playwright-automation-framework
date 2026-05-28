using Microsoft.Playwright;

namespace PlaywrightFramework.Pages;

public class LoginPage : BasePage
{
    public LoginPage(IPage page) : base(page)
    {
    }

    // Locators
    private ILocator UsernameInput =>
        Page.Locator("#user-name");

    private ILocator PasswordInput =>
        Page.Locator("#password");

    private ILocator LoginButton =>
        Page.Locator("#login-button");

    private ILocator ErrorMessage =>
        Page.Locator("[data-test='error']");

    // Actions
    public async Task Login(string username, string password)
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