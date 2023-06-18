using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement _move;

    private void Start()
    {
        _move = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) 
        { 
            _move.TryMoveUp();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            _move.TryMoveDown();
        }




    }
}
