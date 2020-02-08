using System.IO;

internal static class Resources
{
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    // Constants
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    private const string BUNDLE = "com.gustavopsantos.scenetoolbarmenu";
    private static readonly string WorkingDirectory = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "Library", "PackageCache")).GetDirectories($"*{BUNDLE}*.*")[0].FullName;
    private static readonly string TemplatesDirectory = Path.Combine(WorkingDirectory, "Editor", "Templates");
    private static readonly string ScriptsDirectory = Path.Combine(WorkingDirectory, "Editor", "Scripts");

    private static readonly string SceneMenuItemTemplateUri = Path.Combine(TemplatesDirectory, "SceneMenuItem.txt");
    private static readonly string SceneToolbarMenuTemplateUri = Path.Combine(TemplatesDirectory, "SceneToolbarMenu.txt");
    internal static readonly string SceneToolbarMenuScriptUri = Path.Combine(ScriptsDirectory, "SceneToolbarMenu.cs");

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    // Properties
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    internal static string SceneMenuItemTemplate => File.ReadAllText(SceneMenuItemTemplateUri);
    internal static string SceneToolbarMenuTemplate => File.ReadAllText(SceneToolbarMenuTemplateUri);
}