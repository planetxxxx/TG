using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_controller : MonoBehaviour
{
    [SerializeField] GameObject StartGame;
    [SerializeField] GameObject EndGame;

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
        screenCT.didPlay = true;
        EndGame.SetActive(false);
        screenCT.nextCustomer();
        Time.timeScale = 1f;

        Destroy(transform.parent.gameObject);
    }
}