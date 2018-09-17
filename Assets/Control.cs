using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Control : NetworkBehaviour
{
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float speed = .2f;

        if (!isLocalPlayer)
        {
            return;
        }

        transform.Translate(0, Input.GetAxis("Horizontal") * speed, 0);
	}

    public override void OnStartLocalPlayer()
    {
		if(NetworkServer.connections.Count == 0) {
			GetComponent<MeshRenderer>().material.color = Color.blue;
			transform.position = new Vector3(9, 1, 0);
			Debug.Log(NetworkServer.connections.Count+1+" conectados cuando la cuenta esta en 0");
		}
		else
		{
			GetComponent<MeshRenderer>().material.color = Color.blue;
			transform.position = new Vector3(-9, 1, 0);
			Debug.Log(NetworkServer.connections.Count + 1 + " conectados");
		}
        
    }
	
	
}
