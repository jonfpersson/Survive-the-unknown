using UnityEngine;
using System.Collections;

public class SphereShooter : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        

        if (Input.GetMouseButtonDown(0))
        {
           // GameObject ball = Instantiate(prefab) as GameObject;
            GameObject ball = (GameObject)PhotonNetwork.Instantiate("ball", transform.position + Camera.main.transform.up * 1.5f + Camera.main.transform.forward * 1.3f, Quaternion.identity, 0);

            //ball.transform.position = transform.position + Camera.main.transform.forward * 1.3f;
            Rigidbody rb = ball.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 40;
        }
	}
}
