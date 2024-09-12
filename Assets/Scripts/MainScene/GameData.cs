using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static GameData Instance;

    public int stageNum = 0;        //스테이지 번호
    public int cardSet = 8;         //카드 매수
    public float timeSet = 60.0f;   //시간제한
    public bool actGimmick = false; //기믹 추가

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
