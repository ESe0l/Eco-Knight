using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameData : MonoBehaviour
{
    public static GameData Instance;
    public int stageNum = 0;
    public int cardSet = 8;
    public float timeSet = 60.0f;
    public bool actGimmick = false;

    public float[] record = new float[10];      //game record
    public bool[] stageUnlock = new bool[10];   //index <- stageNum

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            record = Enumerable.Repeat(float.MaxValue, 10).ToArray();
            stageUnlock[0] = true; //first stage unlock
        }
    }
}
