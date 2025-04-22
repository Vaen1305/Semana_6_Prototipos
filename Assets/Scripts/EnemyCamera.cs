using UnityEngine;

public class EnemyCamera : MonoBehaviour
{
    [SerializeField] private Camera enemyCam;
    [SerializeField] private int MaskWithInvisibility;
    [SerializeField] private int MaskWithoutInvisibility;
    public PlayerController playerController;

    public void OnInvisibleStateChanged(bool isInvisible)
    {
        if (isInvisible)
        {
            enemyCam.cullingMask = MaskWithInvisibility;
        }
        else
        {
            enemyCam.cullingMask = MaskWithoutInvisibility;
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
