using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestState : PlayerBaseState
{
    private float timer;

    public PlayerTestState(PlayerStateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        stateMachine.InputReader.MoveEvent += OnMove;
    }

    public override void Tick(float deltaTime)
    {
        timer += deltaTime;
        Debug.Log(timer);
    }

    public override void Exit()
    {
        stateMachine.InputReader.MoveEvent -= OnMove;
    }

    private void OnMove()
    {
        stateMachine.SwitchState(new PlayerTestState(stateMachine));
    }
}
