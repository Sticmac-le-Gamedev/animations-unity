using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerMovement _playerMovement;

    public void Move(InputAction.CallbackContext ctx) {
        _playerMovement.Move(Math.Sign(ctx.ReadValue<float>()));
    }

    public void Jump(InputAction.CallbackContext ctx) {
        if (ctx.started) {
            _playerMovement.Jump();
        }
    }
}
