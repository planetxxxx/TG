using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_controller : MonoBehaviour
{
    [SerializeField] GameObject StartGame;
    [SerializeField] GameObject EndGame;
    public GameObject iron;
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject needle;
    public GameObject machine;
    public GameObject fabric;
    public AudioSource sew;
    

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startGame()
    {
        sew.Play();
        StartGame.SetActive(false);
        Time.timeScale = 1f;
        fabric.GetComponent<fabric_controller>().speedHor = 25f;
        fabric.GetComponent<fabric_controller>().speedVer = 0.85f;


    }
    public void endGame()
    {
      
      


        Time.timeScale = 1f;
        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
    }
}
