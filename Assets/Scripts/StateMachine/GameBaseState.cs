using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameBaseState
{
    public abstract void EnterState(GameStateManager game);

    public abstract void UpdateState(GameStateManager game);

    public abstract void OnCollisionEnter(GameStateManager game);
}
