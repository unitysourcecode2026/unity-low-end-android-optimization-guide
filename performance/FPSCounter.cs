using UnityEngine;

public class FPSCounter : MonoBehaviour
{
    public float CurrentFPS { get; private set; }

    private float deltaTime;

    private void Update()
    {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;

        if (deltaTime > 0f)
        {
            CurrentFPS = 1f / deltaTime;
        }
    }
}
