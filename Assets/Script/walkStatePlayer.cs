using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkStatePlayer : BaseState
{
    public float horiX, vertZ;

    public override void EnterState(StateManeger State)
    {
        Debug.Log("Entrou no walk State");
    }

    public override void ExitState(StateManeger State)
    {
        State.switchState(State.idleState);
    }

    public override void UpdateState(StateManeger State)
    {
        horiX = Input.GetAxisRaw("Horizontal");
        vertZ = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(horiX, 0, vertZ).normalized;

        State.transform.Translate(dir * 5 * Time.deltaTime);

        if(horiX == 0 && vertZ == 0)
        {
            ExitState(State);
        }
    }
}
