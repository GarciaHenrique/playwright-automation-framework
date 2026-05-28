using NUnit.Framework;
using Allure.NUnit;
using PlaywrightFramework.Core;
using PlaywrightFramework.Pages;

namespace PlaywrightFramework.Tests;

[AllureNUnit]
public class CheckoutTests : BaseTest
{
    [Test]
    public async Task CompletePurchaseFlow()
    {
        // Login
        var loginPage = new LoginPage(Page);

        await loginPage.Login(
            "standard_user",
            "secret_sauce");

        // Inventory
        var inventoryPage =
            new InventoryPage(Page);

        await inventoryPage.AddBackpackToCart();

        await inventoryPage.OpenCart();

        // Cart
        var cartPage = new CartPage(Page);

        await cartPage.Checkout();

        // Checkout
        var checkoutPage =
            new CheckoutPage(Page);

        await checkoutPage.FillCheckoutForm(
            "Henrique",
            "Garcia",
            "12345");

        Assert.That(
            Page.Url,
            Does.Contain("checkout-step-two"));
    }
}