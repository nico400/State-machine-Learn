using UnityEngine;

public abstract class BaseState : MonoBehaviour
{
    public abstract void EnterState(StateManeger State);
    public abstract void UpdateState(StateManeger State);
    public abstract void ExitState(StateManeger State);
}
