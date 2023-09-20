using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerControl playerControl;
    public Vector2 movementInput;
    public float verticalInput;
    public float horizontalInput;

    //Hierarchy: 
    //void Awake
    //voide Enable
    private void OnEnable()
    {
        if (playerControl == null)
        {
            playerControl = new PlayerControl();
            //when WASD is pressed, records the movement to variable
            //PlayerMovement is from PlayerControl Input Action
            playerControl.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
        }
        playerControl.Enable();
    }
    public void OnDisable()
    {
        playerControl.Disable();
    }
    public void HandleAllInput()
    {
        HandleMovementInput();
    }
    private void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x; 
    }
}
