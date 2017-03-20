using UnityEngine;
using System.Collections;

public class spawnBlock : MonoBehaviour {
    public static string objectName = "playCube";
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.E))
        {
            //GameObject myPlayer = (GameObject)PhotonNetwork.Instantiate("Player", pos, Quaternion.identity, 0);
            PhotonNetwork.Instantiate(objectName, (Camera.main.transform.up * 2) + transform.position + Camera.main.transform.forward * 2, Quaternion.identity, 0);
            // cube.transform.position = transform.position + Camera.main.transform.forward * 2;
         //   Rigidbody rb = cube.GetComponent<Rigidbody>();
          //  rb.velocity = Camera.main.transform.forward;
        }
	}
}
