using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEditor;

public class Autobuilder : MonoBehaviour
{

    public static void BuildGame()
    {

        var scenes = new string[] { "Assets/Scenes/SampleScene.unity" };
        var flags = BuildOptions.Development;
        Debug.Log("start");
        BuildPipeline.BuildPlayer(scenes, "test2.apk", BuildTarget.Android, flags);
        Debug.Log("end");

    }

}
