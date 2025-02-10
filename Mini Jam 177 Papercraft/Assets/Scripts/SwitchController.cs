using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SwitchController : MonoBehaviour
{
    [SerializeField] private GameObject interactable;
    private DoorRotation _doorRotationScript;
    private DynamicPlatform _dynamicPlatformScript;
    private AccordionPlatform _accordionResizerScript;
    
    void Start()
    {
        if (CompareTag("Green"))
            _doorRotationScript = interactable.GetComponent<DoorRotation>();
        else if (CompareTag("Pink"))
            _dynamicPlatformScript = interactable.GetComponent<DynamicPlatform>();
        else if (CompareTag("Blue"))
            _accordionResizerScript = interactable.GetComponent<AccordionPlatform>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (CompareTag("Green"))
                ToggleDoor();

            if (CompareTag("Pink"))
                ShowPlatform();

            if (CompareTag("Blue"))
                StretchPlatform();
        }
    }
    
    private void ToggleDoor()
    {
        _doorRotationScript.toggleDoorRotation = true;
    }

    private void ShowPlatform()
    {
        interactable.SetActive(true);
    }

    private void StretchPlatform()
    {
        _accordionResizerScript.on = true;
    }
}
