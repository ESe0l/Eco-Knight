using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    GameObject easy_Btn;
    GameObject normal_Btn;
    GameObject Hard_Btn;

    bool stage_Unlock = false;
    public void Unlock()
    {
        GameData.Instance.stageUnlock = stage_Unlock;
        if(stage_Unlock == true)
        {
            normal_Btn.SetActive(true);
        }
    }
}
