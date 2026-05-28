using NUnit.Framework;
using PlaywrightFramework.Api;
using System.Net;

namespace PlaywrightFramework.Tests;

public class ApiTests
{
    [Test]
    public async Task GetUsersShouldReturn200()
    {
        var api = new ApiClient();

        var response =
            await api.GetUsers();

        Assert.That(
            response.StatusCode,
            Is.EqualTo(HttpStatusCode.OK));
    }
}