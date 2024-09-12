using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour
{
    public Slider volSlider;
    public Text volTxt;

    // Start is called before the first frame update
    void Start()
    {

        float value = AudioManager.Instance.GetVolume();
        volSlider.value = value;
        volTxt.text = (value * 100).ToString("N0");
    }

    // Update is called once per frame
    void Update()
    {

    }
}