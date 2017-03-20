using UnityEngine;
using System.Collections;

public class networkCharacter : Photon.MonoBehaviour {
    Vector3 realPosition = Vector3.zero;
    Quaternion realRotation = Quaternion.identity;
    //float lastUpdateTime;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //PhotonView photonView = GetComponent<PhotonView>();
        if (photonView.isMine)
        {
            //do nothing
        }else
        {
            transform.position = Vector3.Lerp(transform.position, realPosition, 0.1f);
            transform.rotation = Quaternion.Lerp(transform.rotation, realRotation, 0.1f);
        }
	}
    
   public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.isWriting)
        {

            stream.SendNext(transform.position);
            stream.SendNext(transform.rotation);
        }
        else
        {
            realPosition = (Vector3) stream.ReceiveNext();
            realRotation= (Quaternion) stream.ReceiveNext();
        }
    }

}
