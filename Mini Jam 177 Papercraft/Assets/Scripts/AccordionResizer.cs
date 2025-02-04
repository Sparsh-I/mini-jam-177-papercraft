using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccordionResizer : MonoBehaviour
{
    [SerializeField] private float originalWidth;
    [SerializeField] private float originalHeight;
    [SerializeField] private float minWidth;
    [SerializeField] private float maxWidth;
    [SerializeField] private float speed;
    private float _newHeight;
    private BoxCollider2D _collider;
    public bool on = false;

    void Start()
    {
        _collider = GetComponent<BoxCollider2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (on) StartAccordion();
    }

    private void StartAccordion()
    {
        float newWidth = Mathf.PingPong(Time.time * speed, maxWidth - minWidth) + minWidth;
        
        // Resize object
        transform.localScale = new Vector3(newWidth, originalHeight, transform.localScale.z);
     
        if (_collider) _collider.size = new Vector2(transform.localScale.x / newWidth, transform.localScale.y / originalHeight);
    }
}
