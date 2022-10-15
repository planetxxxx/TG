using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronCt : MonoBehaviour
{
    public bool _dragging;
    public Vector3 defaultPosition;
    public Vector3 rotationIron;
    public ParticleSystem steam;
    public Sprite highlighted;
    public static Sprite normal;
    public AudioSource steamS;
    public static SpriteRenderer rend;

    private void Awake()
    {
        rend = GetComponent<SpriteRenderer>();
        normal = rend.sprite;
        
        GameStateManager.canIron = true;
        
        rotationIron = new Vector3(15f, 0f, 45f);
        defaultPosition = transform.position;
    }
    void Update()
    {
      
       
       
       
    }
    // Start is called before the first frame update
    private void OnMouseDown()
    {
     
         

        
       
    }
    private void OnMouseUp()
    {
      

        transform.rotation = Quaternion.Euler(0, 0, 0);
        transform.position = defaultPosition;



    }
    private void OnMouseDrag()
    {


        transform.eulerAngles = rotationIron;
        var mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePosition;



    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "fabric" && collision.gameObject.tag != "machine")
        {
            if (GameStateManager.canIron == true)
            {
                playSteam();
               
            }
          
        }
    }

 
    public void playSteam()
    {
        steamS.Play();
        steam.Play();
        GetComponent<SpriteRenderer>().sprite = highlighted;
        GameStateManager.canIron = false;
    }
  
}
