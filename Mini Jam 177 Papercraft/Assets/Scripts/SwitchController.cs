using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SwitchController : MonoBehaviour
{
    [SerializeField] private GameObject door;
    private DoorRotation _doorRotationScript;
    
    void Start()
    {
        _doorRotationScript = door.GetComponent<DoorRotation>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            ToggleDoor();
    }
    
    private void ToggleDoor()
    {
        _doorRotationScript.toggleDoorRotation = true;
    }
}
