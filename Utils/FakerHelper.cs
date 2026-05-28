using Bogus;

namespace PlaywrightFramework.Utils;

public static class FakerHelper
{
    private static Faker faker = new Faker();

    public static string FirstName()
    {
        return faker.Name.FirstName();
    }

    public static string LastName()
    {
        return faker.Name.LastName();
    }

    public static string ZipCode()
    {
        return faker.Address.ZipCode();
    }
}