using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialMovement : MonoBehaviour
{
    public bool _dragging;
    public Vector3 defaultPosition;

    private void Awake()
    {

        defaultPosition = transform.position;
    }
    void Update()
    {
        if (_dragging )
        {
            
            if (!GameStateManager.didFabric)
            {
                var mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = mousePosition;
            }
           


        }
        

        if(GameStateManager.didFabric)
        {
            transform.position = defaultPosition;
        }

    }
    // Start is called before the first frame update
    private void OnMouseDown()
    {   
        _dragging = true;
    }
    private void OnMouseUp()
    {
        _dragging = false;
        transform.position = defaultPosition;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("machine"))
        {
            GameStateManager.didFabric = true;
            
        }
    }








}
