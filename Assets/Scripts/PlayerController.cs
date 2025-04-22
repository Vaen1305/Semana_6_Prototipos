using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public delegate void InvisibleStateChanged(bool isInvisible);
    public event InvisibleStateChanged OnInvisibleStateChanged;

    private bool isInvisible = false;

    public void OnInvisible(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            isInvisible = !isInvisible;

            OnInvisibleStateChanged?.Invoke(isInvisible);

            int targetLayer;
            if (isInvisible)
            {
                targetLayer = LayerMask.NameToLayer("Invisible");
            }
            else
            {
                targetLayer = LayerMask.NameToLayer("Default");
            }

            gameObject.layer = targetLayer;
        }
    }
}