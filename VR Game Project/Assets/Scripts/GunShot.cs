using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShot : MonoBehaviour {

    [SerializeField] private Transform _raycastOrigin;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            RaycastHit hit;

            Physics.Raycast(_raycastOrigin.position, _raycastOrigin.forward, out hit, 1000.0f);
            Debug.Log("Bang Bang");

        }

        Debug.DrawRay(_raycastOrigin.position, _raycastOrigin.forward, Color.red, 100.0f);

    }
}
