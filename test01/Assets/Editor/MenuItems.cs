using UnityEngine;
using UnityEditor;

public class MenuItems
{
    [MenuItem("Tools/Autobuilder")]
    private static void NewMenuOption()
    {
        Autobuilder.BuildGame();
    }
}
