
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavAgentBehaviour : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform player;
    //public float speed = -0.5f;
    private Transform currentDestination;
    private int i;
    public bool canHunt;
    public List<Transform> patrolPoints;
    public EnemyShoot _Shoot;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //agent.speed = speed;
        currentDestination = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") == true)
        {
            canHunt = true;
            currentDestination = player;
        }
        if (canHunt == true)
        {
            _Shoot.canClone = true;
            _Shoot.AttackPlayer();
        }

    }

    private void OnTriggerExit(Collider other)
    {
        canHunt = false;
        currentDestination = transform;
        _Shoot.StopFiring();
    }
    

    void Update()
    {
        // transform.LookAt(agent.steeringTarget);
        if (canHunt)
        {
            agent.destination = currentDestination.position;
            return;
        }

        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            agent.destination = patrolPoints[i].position;
            i = (i + 1) % patrolPoints.Count;
        }
    }
}