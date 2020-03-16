using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider Master;
    public Slider Music;
    public Slider SFX;

    private void Start()
    {
        float value;
        if (mixer.GetFloat("MasterVol", out value))
        {
            Master.value = value;
        }
        if (mixer.GetFloat("MusicVol", out value))
        {
            Music.value = value;
        }
        if (mixer.GetFloat("SFXVol", out value))
        {
            SFX.value = value;
        }
    }

    public void SetLP(float freq)
    {
        mixer.SetFloat("LowP", freq);
    }
    private void Update()
    {
        mixer.SetFloat("SFXVol", SFX.value);
        mixer.SetFloat("MusicVol", Music.value);
        mixer.SetFloat("MasterVol", Master.value);
    }
}

