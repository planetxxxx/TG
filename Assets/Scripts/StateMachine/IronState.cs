using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronState : GameBaseState
{
    public override void EnterState(GameStateManager game)
    {

    }

    public override void OnCollisionEnter(GameStateManager game)
    {
       
    }

    public override void UpdateState(GameStateManager game)
    {
        if (screenCT.didFabric && screenCT.didPlay)
        {
            game.SwitchState(game.playingState);
        }
    }
}
