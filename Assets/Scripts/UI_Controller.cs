using UnityEngine;
using TMPro;

public class UI_Controller : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI statusText;
    public PlayerController playerController;

    public void OnInvisibleStateChanged(bool isInvisible)
    {
        if (isInvisible)
        {
            statusText.text = "Invisible Activo";
        }
        else
        {
            statusText.text = "Invisible Desactivado";
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