using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private PhotonView MyPhotonView;
	private void Start()
	{
		MyPhotonView = GetComponent<PhotonView>();
	}

	private void Update()
    {
		if (!MyPhotonView.IsMine) return;
		if (Input.GetKey(KeyCode.LeftArrow)) { transform.position = new Vector3(transform.position.x - 0.1f, 1.5f, transform.position.z); }
        if (Input.GetKey(KeyCode.RightArrow)) { transform.position = new Vector3(transform.position.x + 0.1f, 1.5f, transform.position.z); }
		if (Input.GetKey(KeyCode.UpArrow)) { transform.position = new Vector3(transform.position.x, 1.5f, transform.position.z + 0.1f); }
		if (Input.GetKey(KeyCode.DownArrow)) { transform.position = new Vector3(transform.position.x, 1.5f, transform.position.z - 0.1f); }
	}
}
