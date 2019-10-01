﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEditor;

public class Autobuilder : MonoBehaviour
{

    public static void BuildGame()
    {
        Console.Write("###hello");
        var scenes = new string[] { "Assets/Scenes/SampleScene.unity" }; //test
        var flags = BuildOptions.Development;
        Debug.Log("###start");
        BuildPipeline.BuildPlayer(scenes, "D:/젠킨스/workspace/TEST02/test2.apk", BuildTarget.Android, flags);
        Debug.Log("###end");

    }

}
