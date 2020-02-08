using System.IO;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

internal static class DynamicClassGenerator
{
    internal static void GenerateMenu()
    {
        // Scene files info
        string[] uris = Directory.GetFiles(Application.dataPath, "*.unity", SearchOption.AllDirectories).OrderBy(Path.GetFileName).ToArray();
        string[] urns = uris.Select(Path.GetFileName).ToArray();

        // Caching text file templates
        string sceneMenuItemTemplate = Resources.SceneMenuItemTemplate;
        string sceneToolbarMenuTemplate = Resources.SceneToolbarMenuTemplate;
        
        // Creating menu items for each scene file found
        StringBuilder items = new StringBuilder();
        for (int i = 0; i < urns.Length; i++)
        {
            if (items.Length > 0)
            {
                // Add a new line and tab to keep items indented.
                items.Append("\n\t");
            }

            string sceneName = urns[i].Replace(".unity", string.Empty);
            string sceneNormalizedName = sceneName.RemoveSpecialCharacters();
            
            string item = sceneMenuItemTemplate;
            item = item.Replace("_SCENE_NAME_", sceneName);
            item = item.Replace("_SCENE_NORMALIZED_NAME_", sceneNormalizedName);
            item = item.Replace("_SCENE_URI_", uris[i]);

            items.Append(item);
        }

        // Generating new SceneToolbarMenu.cs based on template
        string csSceneToolbarMenu = sceneToolbarMenuTemplate.Replace("_ITEMS_", items.ToString());
        
        // Generating new SceneToolbarMenu.cs based on template
        File.WriteAllText(Resources.SCENE_TOOLBAR_MENU_SCRIPT_URI, csSceneToolbarMenu);
        
        // Refreshing database so unity can compile the new SceneToolbarMenu.cs file
        AssetDatabase.Refresh();
    }
}