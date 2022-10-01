using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigame_controller : MonoBehaviour
{
    [SerializeField] GameObject sewMachine;
    [SerializeField] GameObject minigamePrefab;
    [SerializeField] bool startGame;
    // Start is called before the first frame update
    void Start()
    {
        startGame = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(startGame)
        {
            Instantiate(minigamePrefab);
        }
    }
}
