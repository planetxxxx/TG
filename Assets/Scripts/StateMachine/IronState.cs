using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronState : GameBaseState
{
    public override void EnterState(GameStateManager game)
    {
        GameStateManager.canIron = true;
        GameStateManager.didTalk = false;
    }

    public override void OnCollisionEnter(GameStateManager game)
    {
       
    }

    public override void UpdateState(GameStateManager game)
    {
        if (GameStateManager.didFabric && game.currentState == game.ironingState)
        {
            game.StartMiniGame.SetActive(true);
        }
        if (GameStateManager.didFabric && GameStateManager.DidPlayButton)
        {
            
            game.SwitchState(game.playingState);
            
        }
    }
}
