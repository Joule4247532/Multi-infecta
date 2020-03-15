using UnityEngine;
using UnityEngine.UI;

public class InfectBar : MonoBehaviour
{

    public Slider slider;

    public void SetInfectLV(float lv)
    {
        lv = Mathf.Clamp(lv, 0f, 100f);
        slider.value = lv;
    }
}
