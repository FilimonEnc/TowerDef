using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
       PhotonNetwork.ConnectUsingSettings(); 
    }
    
    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
