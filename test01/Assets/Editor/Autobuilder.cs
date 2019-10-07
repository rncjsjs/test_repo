using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEditor;

public class Autobuilder : MonoBehaviour
{

    public static void BuildGame()
    {
        Console.Write("###hello");
        var scenes = new string[] { "Assets/Scenes/SampleScene.unity" }; 
        var flags = BuildOptions.Development;
        Debug.Log("###start");
        BuildPipeline.BuildPlayer(scenes, "C:/Users/Silva/Desktop/GitTest/TEST01/test01/test2.apk", BuildTarget.Android, flags);
        Debug.Log("###end");

    }

}
