using UnityEngine;
using UnityEngine.AI;

//---------------------------------------------------------------------------------
// Author		: Gabriel Loke
// Date  		: 10/02/23
// Description	: Enemy AI
//---------------------------------------------------------------------------------


public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.SetDestination(player.position);
    }
}