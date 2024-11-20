using UnityEngine;
using UnityEngine.InputSystem;

public class HideOrDisplay : MonoBehaviour
{
    [SerializeField]
    InputAction hideOrDisplay = new InputAction(type: InputActionType.Button);

    private Renderer rendererComponent;   

    private void OnEnable()
    {
        hideOrDisplay.Enable();
    }

    private void OnDisable()
    {
        hideOrDisplay.Disable();
    }

    private bool isDisplayed()
    {
        return rendererComponent.enabled;
    }

    private void Hide()
    {
        if (rendererComponent != null)
        {
            rendererComponent.enabled = false;
        }
    }


    private void Display()
    {
        if (rendererComponent != null)
        {
            rendererComponent.enabled = true;
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rendererComponent = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hideOrDisplay.WasPressedThisFrame())
        {
            if (isDisplayed())
            {
                Hide();
            }
            else
            {
                Display();
            }
        }
    }
}
