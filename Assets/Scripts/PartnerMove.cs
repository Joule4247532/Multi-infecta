using System;
using UnityEngine;
using UnityEngine.AI;

public class PartnerMove : MonoBehaviour
{
    NavMeshAgent _navMeshAgent;
    public bool Go = false;

    public Transform _target;


    // Start is called before the first frame update
    void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player").transform;
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        _navMeshAgent.updateUpAxis = false;

        if (_navMeshAgent == null)
        {
            Debug.Log("Not good nav mesh");
        }
        else
        {
            SetDestination(_target);
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
            SetDestination(_target);
        }
    }

    public void die()
    {
        this.tag = "Untagged";
        throw new NotImplementedException();
    }

    public void live()
    {
        this.tag = "Untagged";
        throw new NotImplementedException();
    }
}
