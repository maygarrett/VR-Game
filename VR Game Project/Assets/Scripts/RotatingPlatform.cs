using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour {

    private float _rotationValue = 10.0f;
    private float _rotationSpeed = 0.1f;

    [SerializeField] private bool _positive = true;

	// Use this for initialization
	void Start () {
        StartCoroutine(FlipDirection());
	}
	
	// Update is called once per frame
	void Update () {

        if(_positive)
        {
            transform.Rotate(new Vector3(0.5f, 0, 0));
        }

        if(!_positive)
        {
            transform.Rotate(new Vector3(-0.5f, 0, 0));
        }

        
    }


    private IEnumerator FlipDirection()
    {
        yield return new WaitForSeconds(1.0f);
        StartCoroutine(FlipDirection());
        _positive = !_positive;
    }
}
