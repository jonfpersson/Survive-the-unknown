using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NetworkManager : MonoBehaviour {
    Vector3 pos;
    public GameObject lobbyCamera;
    public static GameObject myPlayer;
    public static bool canConnect = true;
    // Use this for initialization
    void Start () {
        canConnect = true;
        pos = new Vector3(151, 48.198f, 224);

    }

    void Update()
    {
        if (canConnect)
        Connect();
        

    }
    void Connect()
    {
        PhotonNetwork.ConnectUsingSettings("Survive the unknown OPEN BETA 0.07493");
        //PhotonNetwork.offlineMode = true;
    }


    void OnGUI()
    {
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
    }

    void OnJoinedLobby()
    {
        Debug.Log("OnJoinedLobby");
        PhotonNetwork.JoinRandomRoom();
    }
    void OnPhotonRandomJoinFailed()
    {
        Debug.Log("OnPhotonRandomJoinFailed");
        PhotonNetwork.CreateRoom(null);
    }

    void OnJoinedRoom()
    {
        Debug.Log("OnJoinedRoom");
        spawnPlayer();
    }


    void spawnPlayer()
    {

        myPlayer = (GameObject) PhotonNetwork.Instantiate("jeff", pos, Quaternion.Euler(0, 0, 0), 0);
        myPlayer.GetComponent<spawnBlock>().enabled = true;
        myPlayer.GetComponent<PlayerSprint>().enabled = true;
        myPlayer.GetComponent<CharacterMotor>().enabled = true;
        myPlayer.GetComponent<MouseLook>().enabled = true;
        myPlayer.GetComponent<FPSInputController>().enabled = true;
        myPlayer.GetComponent<displayHp>().enabled = true;
        myPlayer.GetComponent<SphereShooter>().enabled = true;
        myPlayer.GetComponent<PickAndDrop>().enabled = true;
        myPlayer.GetComponent<displayHp>().enabled = true;

        myPlayer.transform.FindChild("Main Camera").gameObject.SetActive(true);
        lobbyCamera.SetActive(false);
    }

    void OnConnectionFail()
    {
        Application.LoadLevel("LobbyScene");
    }

    private void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }


    }

