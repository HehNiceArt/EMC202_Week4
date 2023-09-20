using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance { get; private set; }
    //Player GameObject
    public GameObject player;
    //PlayerScrpts
    InputManager inputManager;
    PlayerLocomotor playerLocomotor;
    //Player Stats
    public float movementSpeed;
    public float rotationSpeed;

    public void Awake()
    {
        //if two or more instance, delete self, else use self
        if(instance != null && instance != this) { Destroy(this); }
        else { instance = this; }
        inputManager = GetComponent<InputManager>();
        playerLocomotor = GetComponent<PlayerLocomotor>();
    }

    // Update is called once per frame
    private void Update()
    {
        inputManager.HandleAllInput();
    }
    private void FixedUpdate()
    {
        playerLocomotor.HandleAllMovement();
    }
}
