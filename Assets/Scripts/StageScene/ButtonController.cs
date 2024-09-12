 using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public int stage_Num;
    public int card_Set;
    public int time_Set;
    public bool act_Gimmick = false;
    public void Difficultylevel()
    {
        GameData.Instance.stageNum = stage_Num;
        GameData.Instance.cardSet = card_Set;
        GameData.Instance.timeSet = time_Set;
        GameData.Instance.actGimmick = act_Gimmick;

        if(stage_Num == 0)
        {
            card_Set = 8;
            time_Set = 60;
            SceneManager.LoadScene("MainScene");
        }

        else if(stage_Num == 1)
        {
            card_Set = 16;
            time_Set = 50;
            SceneManager.LoadScene("MainScene");
        }

        else if(stage_Num == 2)
        {
            card_Set = 24;
            time_Set = 45;
            SceneManager.LoadScene("MainScene");
        }
    }
}
