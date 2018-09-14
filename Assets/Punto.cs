using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punto : MonoBehaviour {

    public GameObject bola;

    private void OnTriggerEnter(Collider other)
    {
        bola.transform.position = new Vector3(0, 1, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        bola.transform.position = new Vector3(0,1,0);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
