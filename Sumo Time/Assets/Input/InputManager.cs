using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public Vector2 movementVector, cameraVector;

    public bool JumpButton;
    public void OnMove(InputAction.CallbackContext ctx)
    {
        movementVector = new Vector2(ctx.ReadValue<Vector2>().x, ctx.ReadValue<Vector2>().y);
    }
    public void OnCamera(InputAction.CallbackContext ctx)
    {
        cameraVector = ctx.ReadValue<Vector2>();
    }
    public void OnJump(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            JumpButton = true;
            Invoke("resetJump", .5f);
        }
        else{
            JumpButton = false;
        }
    }
    void resetJump()
    {
        JumpButton = false;
    }
}
