using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomGameManager : MonoBehaviourPunCallbacks
{
    public GameObject PlayerPrefab;

    void Start()
    {
        Vector3 NewPos = new Vector3(Random.Range(-3, 3), 2, Random.Range(-3, 3));
        PhotonNetwork.Instantiate(PlayerPrefab.name, NewPos, Quaternion.identity);
    }

    void Update()
    {
        
    }

    public void Leave() 
    {
        PhotonNetwork.LeaveRoom();
    }

	public override void OnLeftRoom()
	{
        SceneManager.LoadScene(0);
	}

	public override void OnPlayerEnteredRoom(Player newPlayer)
	{
        Debug.LogFormat("Player {0} entered", newPlayer.NickName);
	}

	public override void OnPlayerLeftRoom(Player otherPlayer)
	{
        Debug.LogFormat("Player {0} left room", otherPlayer.NickName);
	}
}
