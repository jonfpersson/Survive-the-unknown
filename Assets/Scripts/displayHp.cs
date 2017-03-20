using UnityEngine;
using System.Collections;

public class displayHp : MonoBehaviour {
    int HpValue;
    private GUIStyle guiStyle; //create a new variable


    // Use this for initialization
    void Start () {
    HpValue = 100;
    guiStyle = new GUIStyle();
    guiStyle.fontSize = 24;
    //guiStyle.normal.textColor = Color.red;

    }

    // Update is called once per frame
    void Update () {
	
	}

    void OnCollisionEnter(Collision coll)
    {
        Debug.Log("1");
        if (coll.gameObject.tag == "ball")
        {
            Debug.Log("2");
            if(HpValue != 0)
            {
                Debug.Log("3");

                //check if the player is not dead
                HpValue = HpValue - 5;
                Debug.Log(HpValue);
            }
            if( HpValue == 0)
            {
                //Reset the player (the player is killed)
                Vector3 temp = new Vector3(151, 50, 224);
                gameObject.transform.position = temp;
                HpValue = 100;
            }
        }
            
    }


    void OnGUI()
    {
        
        GUI.Label(new Rect(1, 30, 180, 40), "HP: "+ HpValue, guiStyle);

    }

}
