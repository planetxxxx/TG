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
        
    }

    // Update is called once per frame
    void Update()
    {
        StartGame.SetActive(false);
    }
    public void startGame()
    {
 
        
        
    }
    public void endGame()
    {
        Debug.Log("sssss");
        GameStateManager.canNextCustomer = true;
        
        Destroy(transform.parent.gameObject);
        EndGame.SetActive(false);
    }
}