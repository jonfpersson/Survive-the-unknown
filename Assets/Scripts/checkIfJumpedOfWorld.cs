using UnityEngine;
using System.Collections;

public class checkIfJumpedOfWorld : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       // Debug.Log(gameObject.transform.position.y + "    " + gameObject.transform.position);
        if (gameObject.transform.position.y < -2){
            
            Vector3 temp = new Vector3(151, 50, 224);
            gameObject.transform.position = temp;
        }
        
    }
}
