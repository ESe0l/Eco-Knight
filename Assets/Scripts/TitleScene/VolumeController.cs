using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public Slider volSlider;
    public Text volTxt;

    public void ChangeVolume()
    {
        float value = volSlider.value;
        AudioManager.Instance.SetVolume(value);
        volTxt.text = (value * 100).ToString("N0");
    }
}