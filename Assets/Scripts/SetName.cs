using UnityEngine;
using System.Collections;

public class SetName : MonoBehaviour
{

    private bool setname = false;
    Vector3 screenPos;


    // Use this for initialization
    void Start()
    {

    }

    void OnGUI()
    {

        GUI.Label(new Rect(Screen.width - (screenPos.x + 20), Screen.height - (screenPos.y + 50), 100, 50), PhotonNetwork.player.name);
    

        if (setname)
        {
            return;
        }

        PhotonNetwork.player.name = GUI.TextField(new Rect(Screen.width / 2 - 50, 20, 100, 100), PhotonNetwork.player.name);

        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 100), "Enter"))
        {
            if (PhotonNetwork.player.name == "")
            {
                Debug.LogError("Enter A Name!");
            }
            else
            {
                NetworkManager.canConnect = true;
                setname = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        screenPos = Camera.main.WorldToScreenPoint(transform.position);
    }

}
