using UnityEngine;
using System.Collections;

public class PlayerSprint : MonoBehaviour {
    CharacterMotor cm;
    float Walkspeed, sprintSpeed;
    float sideWaySpeed, sideWaySprint;
    float backWardSpeed, backWardSprint;
    // Use this for initialization
    void Start () {
        cm = (CharacterMotor)GetComponent<CharacterMotor>();
        Walkspeed = cm.movement.maxForwardSpeed;
        sideWaySpeed = cm.movement.maxSidewaysSpeed;
        backWardSpeed = cm.movement.maxBackwardsSpeed;
        sprintSpeed = Walkspeed * 2;
        sideWaySprint = sideWaySpeed * 2;
        backWardSprint = backWardSpeed * 2;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            cm.movement.maxForwardSpeed = sprintSpeed;
            cm.movement.maxSidewaysSpeed = sideWaySprint;
            cm.movement.maxBackwardsSpeed = backWardSprint;

        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            cm.movement.maxForwardSpeed = Walkspeed;
            cm.movement.maxSidewaysSpeed = sideWaySpeed;
            cm.movement.maxBackwardsSpeed = backWardSpeed;

        }


    }
}
