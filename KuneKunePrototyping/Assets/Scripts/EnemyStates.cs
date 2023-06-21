using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemyStates : MonoBehaviour
{
    //Navmesh and Player Variables 
    
    public NavMeshAgent Mob;

    public Transform Player;

    public LayerMask whatIsGround;

    public LayerMask whatIsPlayer;



    // Patrolling state variables

    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointrange;




    // Sightrange variables

    public float sightRange;
    public bool playerInSightRange;

   

    // On awake find Player and Mob
    private void Awake()
    {
        Player = GameObject.Find("FPC").transform;
        Mob = GetComponent<NavMeshAgent>();

    }

   

    private void Update()
    {
        //Checks for sight and attack range and moves to other functions 
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
       

        if (!playerInSightRange) Patrolling();
        if (playerInSightRange) ChasePlayer();
      

    }

    // Runs the Patrolling function
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

    //Calculates a random walkpoint to give to enemy navmesh agent
    private void SearchWalkPoint()
    {
        float randomZ = Random.Range(-walkPointrange, walkPointrange);
        float randomX = Random.Range(-walkPointrange, walkPointrange);

        walkPoint = new Vector3 (transform.position.x + randomX, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
        {
            walkPointSet = true;
        }
        
            


    }

    //When not in patrolling mode, move enemy mob to player
    private void ChasePlayer()
    {
        Mob.SetDestination(Player.position);
        transform.LookAt(Player);

    }

   

    
    





}
