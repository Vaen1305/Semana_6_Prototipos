using UnityEngine;

public class ParticleSystem : MonoBehaviour
{
    public PlayerController playerController;

    public void OnInvisibleStateChanged(bool isInvisible)
    {
        if (isInvisible)
        {
            Debug.Log("Efecto de Part�culas");
        }
    }

    private void OnEnable()
    {
        if (playerController != null)
        {
            playerController.OnInvisibleStateChanged += OnInvisibleStateChanged;
        }
    }

    private void OnDisable()
    {
        if (playerController != null)
        {
            playerController.OnInvisibleStateChanged -= OnInvisibleStateChanged;
        }
    }
}
