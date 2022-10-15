using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fabric_controller : MonoBehaviour
{
    [SerializeField] float speedVer = 1f;
    [SerializeField] GameObject endCanvas;
    [SerializeField] GameObject needle;
    [SerializeField] GameObject badScore, goodScore, aveScore;
    [SerializeField] Sprite fabYellow, fabGreen, fabPink, fabWhite, fabBlue;
    public float speedHor;
    public string quality;
    string fabColor;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Mouse X") * speedHor * Time.deltaTime, Time.deltaTime * speedVer, 0, Space.World);
        quality = needle.GetComponent<needle_controller>().qua;
        if (fabColor == "green")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = fabGreen;
        }
        if (fabColor == "blue")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = fabBlue;
        }
        if (fabColor == "pink")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = fabPink;
        }
        if (fabColor == "yellow")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = fabYellow;
        }
        if (fabColor == "white")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = fabWhite;
        }
    }
    private void OnBecameInvisible()
    {
        endCanvas.SetActive(true);
        if (quality == "bad")
        {
            badScore.SetActive(true);
        }
        else if (quality == "good")
        {
            goodScore.SetActive(true);
        }
        else if (quality == "ave")
        {
            aveScore.SetActive(true);
        }
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "needle")
        {
            endCanvas.SetActive(true);
            if (quality == "bad")
            {
                badScore.SetActive(true);
            }
            else if (quality == "good")
            {
                goodScore.SetActive(true);
            }
            else if (quality == "ave")
            {
                aveScore.SetActive(true);
            }
            
        }

    }
}