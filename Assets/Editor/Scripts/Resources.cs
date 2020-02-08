using System.IO;

internal static class Resources
{
    //-------------------------------------------------------------------------------------------------------------------------
    // Constants
    //-------------------------------------------------------------------------------------------------------------------------
    private const string BUNDLE_URL = "Packages/com.gustavopsantos/scenetoolbarmenu/";
    private const string TEMPLATES_URL = BUNDLE_URL + "Editor/Templates/";
    private const string SCRIPTS_URL = BUNDLE_URL + "Editor/Scripts/";

    private const string SCENE_MENU_ITEM_TEMPLATE_URI = TEMPLATES_URL + "SceneMenuItem.txt";
    private const string SCENE_TOOLBAR_MENU_TEMPLATE_URI = TEMPLATES_URL + "SceneToolbarMenu.txt";
    internal const string SCENE_TOOLBAR_MENU_SCRIPT_URI = SCRIPTS_URL + "SceneToolbarMenu.cs";

    //-------------------------------------------------------------------------------------------------------------------------
    // Properties
    //-------------------------------------------------------------------------------------------------------------------------
    internal static string SceneMenuItemTemplate => File.ReadAllText(SCENE_MENU_ITEM_TEMPLATE_URI);
    internal static string SceneToolbarMenuTemplate => File.ReadAllText(SCENE_TOOLBAR_MENU_TEMPLATE_URI);
}