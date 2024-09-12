using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static GameData Instance;

    public int stageNum = 0;
    public int cardSet = 8;
    public float timeSet = 60.0f;
    public bool actGimmick = false;

    public float[] record = new float[10]; //Best Record  (index <- stageNum)

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
