using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public static GameManger Instance;
    public Text TimeTxt;
    float time = 60.0f;
    public int cardCount = 0;
    int level = 0;

    int data_Stage = 0;
    int data_Card = 8;
    float data_Time = 60.0f;
    bool data_Gimmick = false;

    // Start is called before the first frame update
    void Start()
    {

        data_Stage = GameData.Instance.stageNum;
        data_Card = GameData.Instance.cardSet;
        time = GameData.Instance.timeSet;
        data_Gimmick = GameData.Instance.actGimmick;

        time = data_Time;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        TimeTxt.text = time.ToString("N2");
    }
}