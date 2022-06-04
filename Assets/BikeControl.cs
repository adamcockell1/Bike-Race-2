using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeControl : MonoBehaviour{

    public Rigidbody2D Frame;
    public Rigidbody2D Rearwheel;
    public Rigidbody2D Frontwheel;
    public float accel = 200;
    public float torque = 100;
    private float currentSpeed = 0f;
    private float currentTilt = 0f;

    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update(){
        currentSpeed = -Input.GetAxisRaw("Vertical") * accel;
        currentTilt = -Input.GetAxisRaw("Horizontal") * torque;
    }

    void FixedUpdate(){
        Rearwheel.AddTorque(currentSpeed * Time.fixedDeltaTime);
        Frame.AddTorque(currentTilt * Time.fixedDeltaTime);
    }
}
