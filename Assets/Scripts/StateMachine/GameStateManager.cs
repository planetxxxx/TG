using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public GameObject Dialogue;

    public GameBaseState currentState;
    public PlayState playingState = new PlayState();
    public IronState ironingState = new IronState();
    public CustomerState customeringState = new CustomerState();
    

    void Start()
    {
        
        currentState = customeringState;

        currentState.EnterState(this);
    }


    void Update()
    {
        currentState.UpdateState(this);
    }
    public void SwitchState(GameBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
    

}
