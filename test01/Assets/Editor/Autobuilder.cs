using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEditor;

class Autobuilder
{

    static void BuildGame()
    {
        Console.Write("###hello");
        var scenes = new string[] { "Assets/Scenes/SampleScene.unity" };
        var flags = BuildOptions.Development;
        Debug.Log("###start");
        BuildPipeline.BuildPlayer(scenes, "d:\test2.apk", BuildTarget.Android, flags);
        Debug.Log("###end");

    }

}
