using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SwitchController : MonoBehaviour
{
    [SerializeField] private GameObject interactable;
    private DoorRotation _doorRotationScript;
    private DynamicPlatform _dynamicPlatformScript;
    
    void Start()
    {
        if (CompareTag("Green"))
            _doorRotationScript = interactable.GetComponent<DoorRotation>();
        else if (CompareTag("Pink"))
            _dynamicPlatformScript = interactable.GetComponent<DynamicPlatform>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (CompareTag("Green"))
                ToggleDoor();

            if (CompareTag("Pink"))
                ShowPlatform();
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
}
