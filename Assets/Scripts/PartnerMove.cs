﻿using System;
using UnityEngine;
using UnityEngine.AI;

public class PartnerMove : MonoBehaviour
{

    [SerializeField]
    Transform _destination;

    NavMeshAgent _navMeshAgent;


    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();

        if (_navMeshAgent == null)
        {
            Debug.Log("Not good nav mesh");
        }
        else
        {
            SetDestination();
        }
    }

    private void SetDestination()
    {
        if (_destination != null)
        {
            Vector3 targetVector = _destination.transform.position;
            _navMeshAgent.SetDestination(targetVector);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
