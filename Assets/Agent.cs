using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour
{
    protected NavMeshAgent myAgent;
    public List<Transform> wayPoint = new List<Transform>();
    private Transform currentWatPoint;
    private int currentIndex = 0;


    public void SetAgent()
    {
        myAgent = GetComponent<NavMeshAgent>();

        if (myAgent == null)
        {
            Debug.Log("No hay Agente!");
        }
    }

    public void SetDestinationAgent()
    {
        if (myAgent.remainingDistance <= myAgent.stoppingDistance)
        {
            myAgent.SetDestination(GetNextTarget().position);
            currentIndex++;
        }
    }

    public Transform GetNextTarget()
    {
        if (currentIndex >= wayPoint.Count)
        {
            currentIndex = 0;
            return wayPoint[currentIndex];
        }
        return wayPoint[currentIndex];
    }

}
