using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OpenPasueMenu : MonoBehaviour {
    //public Button returnMainBtn;

    public GameObject[] menuComponents;
    bool menuIsEnabled;
    // Use this for initialization
    void Start () {
        menuIsEnabled = false;

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(!menuIsEnabled){
                for (int i = 0; i < menuComponents.Length; i++)
                {
                    menuComponents[i].SetActive(true);
                    menuIsEnabled = true;
                    Debug.Log("Enabling");
                }
                NetworkManager.myPlayer.GetComponent<MouseLook>().enabled = false;
                NetworkManager.myPlayer.GetComponent<CharacterMotor>().enabled = false;


            }


            else 
            {
                for (int i = 0; i < menuComponents.Length; i++)
                {
                    menuComponents[i].SetActive(false);
                    menuIsEnabled = false;
                }
                NetworkManager.myPlayer.GetComponent<MouseLook>().enabled = true;
                NetworkManager.myPlayer.GetComponent<CharacterMotor>().enabled = true;

            }

        }

    }
}
