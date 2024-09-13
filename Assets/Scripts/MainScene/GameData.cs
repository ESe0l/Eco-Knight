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

    //Save Data Key
    public readonly string bestEasy = "bestScoreEasy";
    public readonly string bestNormal = "bestScoreNormal";
    public readonly string bestHard = "bestScoreHard";
    public readonly string bestHidden = "bestScoreHidden";
    public readonly string unlockNormal = "unlockNormal";
    public readonly string unlockHard = "unlockHard";
    public readonly string unlockHidden = "unlockHidden";

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
