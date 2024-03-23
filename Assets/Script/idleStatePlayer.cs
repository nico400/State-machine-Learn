using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleStatePlayer : BaseState
{
    public float horiX, vertZ;
    
    public override void EnterState(StateManeger State)
    {
        Debug.Log("Entrou no idle State");
    }

    public override void ExitState(StateManeger State)
    {
        Debug.Log("idle EXIT");
        State.switchState(State.walkState);
    }

    public override void UpdateState(StateManeger State)
    {
        horiX = Input.GetAxisRaw("Horizontal");
        vertZ = Input.GetAxisRaw("Vertical");

        if(horiX != 0 || vertZ != 0)
        {
            ExitState(State);
        }
    }
    
}
