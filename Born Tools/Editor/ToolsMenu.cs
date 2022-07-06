using UnityEditor;
using static System.IO.Directory;
using static System.IO.Path;
using static UnityEditor.AssetDatabase;
using static UnityEngine.Application;

public static class ToolsMenu
{
    [MenuItem("Tools/Setup/Create Default Folders")]
    public static void CreateDefaultFolders()
    {
        string[] dirs = { "_Project", "Art", "Scripts", "Scenes", "Prefabs", "Audio","Animations" };
        CreateDirs("_Project", dirs);
        Refresh();
    }

    private static void CreateDirs(string root, params string[] dirs)
    {
        string fullPath = Combine(dataPath, root);
        foreach (string newDir in dirs)
        {
            CreateDirectory(Combine(fullPath, newDir));
        }
    }
}
