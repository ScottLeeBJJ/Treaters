using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    // Entering a state
    public abstract void Enter();

    // Everything that happens within the state
    public abstract void Tick(float deltaTime);

    // Things that happen when leaving a state
    public abstract void Exit();
}
