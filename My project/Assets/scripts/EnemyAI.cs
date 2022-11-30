using UnityEngine.AI;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player
    public LayerMask whatIsGround, whatIsPlayer;

    //patroling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //Attacking
    public float timeBetweenAttacks;
    bool alreadyAttacked;

    //states
    public float sightRange, attackRange;
    public bool playerInAttackRange, playerInSightRange;

    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent <NavMeshAgent>();

        
    }

    private void Update()
    {
        //check for sight and attack range
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (!playerInSightRange && !playerInAttackRange) Patroling();
        if (playerInSightRange && !playerInAttackRange) ChasePlayer();
        if (playerInSightRange && playerInAttackRange) AttackPlayer();

    }

    private void Patroling()
    {

    }
    private void ChasePlayer()
    {

    }
    private void AttackPlayer()
    {

    }
}
