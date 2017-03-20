using UnityEngine;
using System.Collections;

public class checkBallVelocity : MonoBehaviour {
   

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.transform.position.y < -2)
        {

            GameObject.Destroy(this.gameObject);
        }
    }

    
}
