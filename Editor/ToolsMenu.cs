using UnityEditor;

using static UnityEngine.Application;
using static UnityEditor.AssetDatabase;
using static System.IO.Directory;
using static System.IO.Path;

namespace DiverDan.Tools
{
    public static class ToolsMenu 
    {
        const string menuLocation = "Tools/Setup/";
        static readonly string[] folders = new string[] { "Scripts", "Art", "Scenes"};

        [MenuItem(menuLocation + "CreateDefaultProjectFolder")]
        public static void CreateDefaultFolders()
        {
            CreateDirectory(Combine(dataPath, "_Project"));
            Refresh();
        }

        [MenuItem(menuLocation + "Create New Project Module")]
        public static void CreateProjectModule()
        {
            var fullpath = Combine(dataPath, "_Project");
            if (!Exists(fullpath)) CreateDefaultFolders();
            fullpath = Combine(fullpath, "newModule");
            foreach (var newDirectory in folders)
                CreateDirectory(Combine(fullpath, newDirectory));
            
        }
    }
}
