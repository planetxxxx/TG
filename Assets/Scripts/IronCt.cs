using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronCt : MonoBehaviour
{
    public bool _dragging;
    public Vector3 defaultPosition;
    public Vector3 rotationIron;
    public ParticleSystem steam;
    public Vector2 velocityIron;
    public Sprite highlighted;
    public static Sprite normal;
    public AudioSource steamS;
    public static SpriteRenderer rend;

    private void Awake()
    {
        rend = GetComponent<SpriteRenderer>();
        normal = rend.sprite;
        
        screenCT.canIron = true;
        velocityIron = new Vector2(0, 0);
        rotationIron = new Vector3(15f, 0f, 45f);
        defaultPosition = transform.position;
    }
    void Update()
    {
      
        if (!_dragging)
        {
            transform.position = Vector3.Lerp(transform.position, defaultPosition, 3f * Time.deltaTime);
        }
        if (_dragging)
        {
            var mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePosition;

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
        
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    private void OnMouseDrag()
    {
        transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, rotationIron, 5f* Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "fabric" && collision.gameObject.tag != "machine")
        {
            if (screenCT.canIron == true)
            {
                Invoke("playSteam", 1f);
               
            }
          
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "fabric" && collision.gameObject.tag != "machine")
        {
            CancelInvoke();
        }
    }
    public void playSteam()
    {
        steamS.Play();
        steam.Play();
        screenCT.canIron =false;
        screenCT.didIron = true;
        transform.rotation = Quaternion.Euler(0, 0, 0);
        _dragging = false;
        GetComponent<SpriteRenderer>().sprite = highlighted;


    }
  
}
