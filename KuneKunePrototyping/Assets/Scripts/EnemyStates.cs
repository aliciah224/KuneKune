using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemyStates : MonoBehaviour
{
    public NavMeshAgent Mob;

    public Transform Player;

    public LayerMask whatIsGround;

    public LayerMask whatIsPlayer;



    // Patrolling 

    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointrange;

    //Attacking

    public float timeBetweenAttacks;
    bool alreadyAttacked;


    // States
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

   


    private void Awake()
    {
        Player = GameObject.Find("FirstPersonController").transform;
        Mob = GetComponent<NavMeshAgent>();

    }

   

    private void Update()
    {
        //Checks for sight and attack range 
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (!playerInSightRange && !playerInAttackRange) Patrolling();
        if (playerInSightRange && !playerInAttackRange) ChasePlayer();
        if (playerInAttackRange && playerInSightRange) AttackPlayer();

    }

    private void Patrolling()
    {
        if (!walkPointSet) SearchWalkPoint();

        if (walkPointSet)
        { 
            Mob.SetDestination(walkPoint); 
        }


        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        //If the walkpoint is reached
        if (distanceToWalkPoint.magnitude < 1f)
        {
            walkPointSet = false;
        }
            

    }

    //Calculates a random walkpoint to give to enemy 
    private void SearchWalkPoint()
    {
        float randomZ = Random.Range(-walkPointrange, walkPointrange);
        float randomX = Random.Range(-walkPointrange, walkPointrange);

        walkPoint = new Vector3 (transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
        {
            walkPointSet = true;
        }
        
            


    }

    private void ChasePlayer()
    {
        Mob.SetDestination(Player.position);
           
    }

    private void AttackPlayer()
    {
        transform.LookAt(Player);

    }

    
    





}
