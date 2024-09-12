using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Board : MonoBehaviour
{
    public Transform cards;
    public GameObject card;
    
    // Start is called before the first frame update
    void Start()
    {
	    int[] arr = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 ,7, 7};
		arr = arr.OrderBy(x => UnityEngine.Random.Range(0f, 7f)).ToArray();

        for (int i = 0; i < 16; i++)
        {
            GameObject go = Instantiate(card, this.transform);

            float x = (i / 4) * 1.4f - 1.89f;
            float y = (i % 4) * 1.4f - 0.29f;
            go.transform.position = new Vector2(x, y);

            go.GetComponent<Card>().Setting(arr[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}