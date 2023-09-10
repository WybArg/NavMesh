using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentTwo : Agent
{
    private Transform target;
    public int numLayerEnemy;
    public Transform positionCollider;
    public float colliderRadius;

    void Start()
    {
       SetAgent();
    }


    void Update()
    {
        if (target != null)
        {
            myAgent.SetDestination(target.position);
        }
        else 
        {
            SetDestinationAgent();
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == numLayerEnemy)
        {
            target = other.gameObject.transform;
        }
    }


    public void OnDrawGizmos()
    {
        if (target == null)
        {
            Gizmos.color = Color.green;
        }
        else
        {
            Gizmos.color = Color.red;
        }
        Gizmos.DrawWireSphere(positionCollider.position, colliderRadius);
    }
}
