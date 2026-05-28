using Newtonsoft.Json.Linq;

namespace PlaywrightFramework.Utils;

public static class TestDataReader
{
    public static JObject ReadJson(
        string fileName)
    {
        var path = Path.Combine(
            Directory.GetCurrentDirectory(),
            "..",
            "..",
            "..",
            "TestData",
            fileName);

        var json = File.ReadAllText(path);

        return JObject.Parse(json);
    }
}