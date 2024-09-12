 using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        if(GameData.Instance.stageNum == 0)
        {
            GameData.Instance.cardSet = 8;
            GameData.Instance.timeSet = 60.0f;
            SceneManager.LoadScene("MainScene");
        }

        else if(GameData.Instance.stageNum== 1)
        {
            GameData.Instance.cardSet = 16;
            GameData.Instance.timeSet = 50.0f;
            SceneManager.LoadScene("MainScene");
        }

        else if(GameData.Instance.stageNum == 2)
        {
            GameData.Instance.cardSet = 24;
            GameData.Instance.timeSet = 45.0f;
            SceneManager.LoadScene("MainScene");
        }
    }
}
