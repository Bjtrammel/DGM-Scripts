using System;
using UnityEngine;
using UnityEngine.AI;
using System.Collections;

[RequireComponent(typeof(NavMeshAgent))]
public class Patrol : MonoBehaviour 
{
    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;
    public float speed;
    public bool isStopped = false;

    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        GoToNextPoint();
    }

    public void GoToNextPoint()
    {
        if (points.Length == 0)
        {
            return;
        }

        agent.destination = points[destPoint].position;

        destPoint = (destPoint + 1) % points.Length;
        agent.speed = speed;
    }

    public void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            GoToNextPoint();
        }
    }
}