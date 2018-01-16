using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<Rigidbody>().useGravity = true;

        if(collision.gameObject.tag == "Ground")
        {
            gameObject.GetComponent<MeshCollider>().enabled = true;
            gameObject.GetComponent<SphereCollider>().enabled = false;
            
        }
    }
}
