using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance { get; private set; }
    //Player GameObject
    public GameObject player;
    public Rigidbody rigidBody;
    //PlayerScrpts
    public InputManager inputManager;
    PlayerLocomotor playerLocomotor;
    //Player Stats
    [Range(0f, 1f)]
    public float movementSpeed;
    [Range(0f, 1f)]
    public float rotationSpeed;

    public void Awake()
    {
        //if two or more instance, delete self, else use self
        if(Instance != null && Instance != this) { Destroy(this); }
        else { Instance = this; }
        inputManager = player.GetComponent<InputManager>();
        playerLocomotor = player.GetComponent<PlayerLocomotor>();
        rigidBody = player.GetComponent<Rigidbody>();
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
