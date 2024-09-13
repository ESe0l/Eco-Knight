 using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public int stage_Num;
    public int card_Set;
    public float time_Set;
    public bool act_Gimmick = false;


    public void Difficultylevel() 
    {
        GameData.Instance.stageNum = stage_Num;
        GameData.Instance.cardSet = card_Set;
        GameData.Instance.timeSet = time_Set;
        GameData.Instance.actGimmick = act_Gimmick;

        SceneManager.LoadScene("MainScene");
    }
}