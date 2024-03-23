using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManeger : MonoBehaviour
{
    BaseState currentState;
    public idleStatePlayer idleState = new idleStatePlayer();
    public walkStatePlayer walkState = new walkStatePlayer();

    // Start is called before the first frame update
    void Start()
    {
        currentState = idleState;
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }
    public void switchState(BaseState newState)
    {
        currentState = newState;
        newState.EnterState(this);
    }
}
