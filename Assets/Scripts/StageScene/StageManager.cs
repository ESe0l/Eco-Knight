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
        /*GameData.Instance.stageNum = stage_Num;
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
        }*/
        if (PlayerPrefs.HasKey(GameData.Instance.unlockNormal) && PlayerPrefs.GetInt(GameData.Instance.unlockNormal) == 1)
        {
            normal.SetActive(true);
        }
        else
        {
            normal.SetActive(false);
        }

        if (PlayerPrefs.HasKey(GameData.Instance.unlockHard) && PlayerPrefs.GetInt(GameData.Instance.unlockHard) == 1)
        {
            hard.SetActive(true);
        }
        else
        {
            hard.SetActive(false);
        }

        /*if (PlayerPrefs.HasKey(GameData.Instance.unlockHidden) && PlayerPrefs.GetInt(GameData.Instance.unlockHidden) == 1)
        {
            easy.SetActive(true);
        }
        else
        {
            easy.SetActive(false);
        }*/
    }
}

