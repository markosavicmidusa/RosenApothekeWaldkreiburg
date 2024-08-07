using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public Color dayAmbientColor;
    public Color nightAmbientColor;

    public Light directionalLight;
    public float dayLightIntensity = 1.0f;
    public float nightLightIntensity = 0.2f;

    private bool isDay = true;

    void Start()
    {
        // Initialize to day settings
        RenderSettings.ambientLight = dayAmbientColor;
        directionalLight.intensity = dayLightIntensity;
    }

    void Update()
    {
        // Toggle day/night cycle on 'Q' key press
        if (Input.GetKeyDown(KeyCode.Q))
        {
            isDay = !isDay;
            Debug.Log("Q key pressed");
            if (isDay)
            {
                RenderSettings.ambientLight = dayAmbientColor;
                directionalLight.intensity = dayLightIntensity;
            }
            else
            {
                RenderSettings.ambientLight = nightAmbientColor;
                directionalLight.intensity = nightLightIntensity;
            }
        }
    }
}
