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
    public GameObject hidden;

    public int stage_Num;
    public bool isUnlock;

    public void Start()
    {
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

        if (PlayerPrefs.HasKey(GameData.Instance.unlockHidden) && PlayerPrefs.GetInt(GameData.Instance.unlockHidden) == 1)
        {
            hidden.SetActive(true);
        }
        else
        {
            hidden.SetActive(false);
        }
    }
}

