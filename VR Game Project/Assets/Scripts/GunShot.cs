using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShot : MonoBehaviour {

    [SerializeField] private Transform _raycastOrigin;
    [SerializeField] private GameObject _handgun;

    [SerializeField] private GameObject _gunSparks1;
    [SerializeField] private GameObject _gunSparks2;
    private int _gunSparksCounter = 1;
    private ParticleSystem _gunSparks1System;
    private ParticleSystem _gunSparks2System;



    private Animation _gunAnimation;

    // Use this for initialization
    void Start () {

        _gunAnimation = _handgun.GetComponent<Animation>();

        _gunSparks1System = _gunSparks1.GetComponent<ParticleSystem>();
        _gunSparks2System = _gunSparks2.GetComponent<ParticleSystem>();

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            RaycastHit hit;

            Physics.Raycast(_raycastOrigin.position, _raycastOrigin.forward, out hit, 1000.0f);

            _gunAnimation.Play();

            if(hit.transform.gameObject.tag == "Metal")
            {
                if(_gunSparksCounter == 1)
                {
                    _gunSparks1.transform.position = hit.point;
                    _gunSparks1System.Play();
                    _gunSparksCounter = 2;
                }
                if(_gunSparksCounter == 2)
                {
                    _gunSparks2.transform.position = hit.point;
                    _gunSparks2System.Play();
                    _gunSparksCounter = 1;
                }
            }
                
        }

        Debug.DrawLine(_raycastOrigin.position, _raycastOrigin.forward * 100, Color.red);

    }
}
