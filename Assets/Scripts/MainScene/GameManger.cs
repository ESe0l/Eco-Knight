using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public static GameManger Instance;
    public Text TimeTxt;
    int data_Stage = 0;
    int data_Card = 8;
    float data_Time = 60.0f;
    bool data_Gimmick = false;

    // Start is called before the first frame update
    void Start()
    {
        data_Stage = GameData.Instance.stageNum;
        data_Card = GameData.Instance.cardSet;
        data_Gimmick = GameData.Instance.actGimmick;
        data_Time = GameData.Instance.timeSet;
    }
// Update is called once per frame
    void Update()
    {
        data_Time -= Time.deltaTime;
        TimeTxt.text = data_Time.ToString("N2");
    }
}