using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AISimpleMovement : MonoBehaviour {

    private float _moveSpeed = 3;

    [SerializeField] private Transform _target;

    private bool _isMoving = false;
    private bool _isDone = true;

    private Material _material;

    private NavMeshAgent _agent;



    // Use this for initialization
    void Start()
    {
        _agent = gameObject.GetComponent<NavMeshAgent>();
        _agent.speed = _moveSpeed;
        _material = gameObject.GetComponent<Renderer>().material;
        _material.color = Color.blue;
        // agent.destination = _target.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _isMoving = !_isMoving;
            _isDone = false;
        }
        if (Vector3.Distance(transform.position, _target.position) > 2)
        {
            if (_isMoving && !_isDone)
            {
                _agent.destination = _target.position;
                _material.color = Color.green;
                _isDone = true;
            }

            if (!_isMoving && !_isDone)
            {
                _agent.destination = transform.position;
                _material.color = Color.blue;
                _isDone = true;
            }
        }
        else {
            _agent.destination = transform.position;
            _material.color = Color.blue;
        }
    }
}