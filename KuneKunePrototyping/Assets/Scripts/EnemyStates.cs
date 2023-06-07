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



    // Patrolling state

    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointrange;




    // States
    public float sightRange;
    public bool playerInSightRange;

   

    //Defines what is considered the Player and enemy mob
    private void Awake()
    {
        Player = GameObject.Find("FirstPersonController").transform;
        Mob = GetComponent<NavMeshAgent>();

    }

   

    private void Update()
    {
        //Checks for sight and attack range 
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
       

        if (!playerInSightRange) Patrolling();
        if (playerInSightRange) ChasePlayer();
      

    }

    // Sends enemy mob between the searching and moving to a walkpoint
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

    //When not in patrolling mode, move enemy mob to player
    private void ChasePlayer()
    {
        Mob.SetDestination(Player.position);
        transform.LookAt(Player);

    }

   

    
    





}
