using UnityEngine;

public class PerformanceSettings : MonoBehaviour
{
    [Header("Target Frame Rates")]
    [SerializeField] private int lowEndTargetFPS = 30;
    [SerializeField] private int standardTargetFPS = 60;

    [Header("Memory Threshold")]
    [SerializeField] private int lowEndMemoryThresholdMB = 4096;

    private void Awake()
    {
        ConfigurePerformance();
    }

    private void ConfigurePerformance()
    {
        int systemMemory = SystemInfo.systemMemorySize;

        if (systemMemory > 0 && systemMemory <= lowEndMemoryThresholdMB)
        {
            Application.targetFrameRate = lowEndTargetFPS;

            if (QualitySettings.names.Length > 0)
            {
                QualitySettings.SetQualityLevel(0, true);
            }
        }
        else
        {
            Application.targetFrameRate = standardTargetFPS;
        }
    }
}
