using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public Transform cards;
    public GameObject card;
    // Start is called before the first frame update
    void Start()
    {
        int[] arr = {0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 };
        for (int i = 0; i <8; i++) //9, 16, 25, ? //0~7
        {
            GameObject go = Instantiate(card);
            go.transform.parent = cards;

            float x = (i % 4) * 1.4f - 1.89f;
            float y = (i / 4) * 1.4f - 0.19f;
            go.transform.position = new Vector2(x, y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
