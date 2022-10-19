using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fabric_controller : MonoBehaviour
{
    [SerializeField] float speedVer = 1f;
    [SerializeField] GameObject endCanvas;
    [SerializeField] GameObject needle;
    [SerializeField] GameObject badScore, goodScore, aveScore;
    public float speedHor;
    public string quality;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Mouse X") * speedHor * Time.deltaTime, Time.deltaTime * speedVer, 0, Space.World);
        gameObject.GetComponent<SpriteRenderer>().color = CustomerState.currentColor;
        quality = needle.GetComponent<needle_controller>().qua;
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