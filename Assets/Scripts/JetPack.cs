using UnityEngine;
using System.Collections;

public class JetPack : MonoBehaviour {
    CharacterController cc;
    CharacterMotor cm;


	// Use this for initialization
	void Start () {
        cc = (CharacterController)GetComponent<CharacterController>();
        cm = (CharacterMotor)GetComponent<CharacterMotor>();

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            Vector3 velocity = new Vector3(cc.velocity.x, 4, cc.velocity.z);
            cm.SetVelocity(velocity);
        }
	}
}
