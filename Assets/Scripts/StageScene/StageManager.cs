using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.GameCenter;

public class StageManager : MonoBehaviour
{
    public GameObject easy;
    public GameObject normal;
    public GameObject hard;

    public int stage_Num;
    public bool isUnlock;

    public void Start()
    {
        GameData.Instance.stageNum = stage_Num;
        if(isUnlock)
        {
            if (stage_Num == 0)
            {
                if (GameManager.isUnlock == true)
                {
                    normal.SetActive(true);
                }
            }
            if(stage_Num == 1)
            {
                if (GameManager.isUnlock == true)
                {
                    hard.SetActive(true);
                }
            }
        }
    }
}

