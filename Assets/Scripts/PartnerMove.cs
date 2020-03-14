using System;
using UnityEngine;
using UnityEngine.AI;

public class PartnerMove : MonoBehaviour
{

    [SerializeField]
    Transform _destination;

    NavMeshAgent _navMeshAgent;
    public bool Go = false;


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
            SetDestination(_destination);
        }
    }

    void SetDestination(Transform _target)
    {
        if (_target != null)
        {
            Vector3 targetVector = _target.transform.position;
            _navMeshAgent.SetDestination(targetVector);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (true)
        {
            Go = false;
            SetDestination(_destination);
        }
    }
}
