using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRotation : MonoBehaviour
{
    const float RotationPerSecond = 180f;
    private float _amountRotated;
    private bool _isRotating;
    private float _frameRotation;

    public bool toggleDoorRotation;
    
    void Start()
    {
        _amountRotated = 0f;
        _isRotating = false;
    }

    void Update()
    {
        if (toggleDoorRotation && !_isRotating) {
            _isRotating = true;
            StartCoroutine(Rotate90());
        }
    }

    IEnumerator Rotate90()
    {
        _amountRotated = 0f;
        while (_amountRotated < 90f) {
            _frameRotation = RotationPerSecond * Time.deltaTime;
            transform.Rotate(0, _frameRotation, 0);
            _amountRotated += _frameRotation;
            yield return new WaitForEndOfFrame();
        }
        toggleDoorRotation = false;
        _isRotating = false;
        gameObject.SetActive(false);
    }
}
