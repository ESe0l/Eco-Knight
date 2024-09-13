using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.GameCenter;

public class StageManager : MonoBehaviour
{
    public GameObject easy;
    public GameObject normal;
    public GameObject Hard; 
    public StageManager Instance;

    public bool [] stage_Unlock;

    public void Unlock()
    {
        GameData.Instance.stageUnlock = new bool [10];
        bool [] stageUnlock = {easy, normal, Hard};

        if(stageUnlock[0])
        {
            
        }
    }  

}
