public static string WebsiteName()
{
    return GetEnvironmentVariable("WEBSITE_SITE_NAME");
}

private static string GetEnvironmentVariable(string name)
{
    return System.Environment.GetEnvironmentVariable(name, EnvironmentVariableTarget.Process);
}