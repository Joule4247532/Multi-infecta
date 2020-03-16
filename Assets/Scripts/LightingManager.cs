using UnityEngine;

//[ExecuteInEditMode]
[ExecuteAlways]
public class LightingManager : MonoBehaviour
{
    //References
   [SerializeField] private Light DirectionalLight;
   [SerializeField] private LightingPreset Preset;
    //Variables
   [SerializeField, Range(0, 96)] private float TimeOfDay;

    private void Update()
    {
        if (Preset == null)
            return;
        if (Application.isPlaying)
        {
            TimeOfDay += Time.deltaTime;
                TimeOfDay %= 96;
            UpdateLighting(TimeOfDay / 96f);
        }
        else
        {
            UpdateLighting(TimeOfDay / 96f);
        }
    }


    private void UpdateLighting(float timePercent)
    {
        RenderSettings.ambientLight = Preset.ambientColor.Evaluate(timePercent);
        RenderSettings.fogColor = Preset.fogColor.Evaluate(timePercent);

        if (DirectionalLight != null)
        {
            DirectionalLight.color = Preset.directionalColor.Evaluate(timePercent);
            DirectionalLight.transform.localRotation = Quaternion.Euler(new Vector3((timePercent * 360f) - 90f, 170, 0));
        }
    } 





    private void OnValidate()
    {
        if (DirectionalLight != null)
            return;
        if (RenderSettings.sun != null)
        {
            DirectionalLight = RenderSettings.sun;

        }
        else
        {
            Light[] lights = GameObject.FindObjectsOfType<Light>();
            foreach(Light light in lights)
            {
                if (light.type == LightType.Directional)
                {
                    DirectionalLight = light;
                        return;
                }
            }
        }
    }
}
