using NUnit.Framework;
using Allure.NUnit;
using PlaywrightFramework.Core;
using PlaywrightFramework.Pages;

namespace PlaywrightFramework.Tests;

[AllureNUnit]
public class LoginTests : BaseTest
{
    [Test]
    public async Task SuccessfulLogin()
    {
        // Arrange
        var loginPage = new LoginPage(Page);

        // Act
        await loginPage.Login(
            "standard_user",
            "secret_sauce");

        // Assert
        Assert.That(
            Page.Url,
            Does.Contain("inventory"));
    }
}