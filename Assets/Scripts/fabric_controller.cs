using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fabric_controller : MonoBehaviour
{
    public float speedVer = 1f;
    [SerializeField] GameObject endCanvas;
    [SerializeField] GameObject needle;
    [SerializeField] GameObject badScore, goodScore, aveScore;
    [SerializeField] Sprite fabYellow, fabGreen, fabPink, fabWhite, fabBlue;
    public GameObject canvas;
    public float speedHor;
    public string quality;
    string fabColor;
    public Vector3 defaultPos;
    public GameObject start;
    public GameObject exit;
    public GameObject startBut;
    public GameObject exitBut;


    // Start is called before the first frame update
    void Start()
    {
        defaultPos = transform.position;
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


        start.SetActive(false);
        exit.SetActive(true);
        startBut.SetActive(false);
        exitBut.SetActive(true);

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
        Time.timeScale = 0f;


        
    }

    public void sifirla()
    {

        transform.position = defaultPos;
        badScore.SetActive(false);
        goodScore.SetActive(false);
        aveScore.SetActive(false);
        needle.GetComponent<needle_controller>().score = 0;
        speedVer = 0;
        speedHor = 0;
        
    }

}
