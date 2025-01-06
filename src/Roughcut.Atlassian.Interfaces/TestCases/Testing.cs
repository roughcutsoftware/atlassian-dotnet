using System.IO;

namespace Roughcut.Atlassian.Interfaces.TestCases
{
    public static class Testing
    {
        public static string TestingDirectory2 { get; set; } = @"C:\repos\RoughcutSoftware\atlassian-dotnet\src\Roughcut.Atlassian.Interfaces\TestCases\";

        public static string TestingDirectory()
        {
            // get parent directory of the current directory
            // C:\repos\RoughcutSoftware\atlassian-dotnet\tests\Roughcut.Atlassian.Infrastructure.Tests\bin\Debug\net8.0
            string parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string currentDirectory = Directory.GetCurrentDirectory();

            //
            string testingDirectory = @"C:\repos\RoughcutSoftware\atlassian-dotnet\src\Roughcut.Atlassian.Interfaces\TestCases\";

            //
            return testingDirectory;
        }
    }
}
