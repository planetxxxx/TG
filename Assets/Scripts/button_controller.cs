using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_controller : MonoBehaviour
{
    [SerializeField] GameObject StartGame;
    [SerializeField] GameObject EndGame;

    public GameObject needle;
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
        StartGame.SetActive(false);
        Time.timeScale = 1f;


    }
    public void endGame()
    {
      
      


        Time.timeScale = 1f;
    }
}
