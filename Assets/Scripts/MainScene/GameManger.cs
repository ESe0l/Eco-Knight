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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        TimeTxt.text = time.ToString("N2");
    }
}