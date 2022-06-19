using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{


    void Start()
    {  

    }

    void Update()
    {
        Vector2 mousePosition = Mouse.current.position.ReadValue();
        if(Keyboard.current.anyKey.wasPressedThisFrame)
        {
            Debug.Log("a key was pressed");
        }

        // Gamepad input goes here
    }
}
