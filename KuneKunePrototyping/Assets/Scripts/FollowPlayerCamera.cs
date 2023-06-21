using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Minimap camera follows player 
public class FollowPlayerCamera : MonoBehaviour
{
    public Transform TargetTransform;

    private float xOffset;
    private float yOffset;
    private float zOffset;

    //Calculates offset based off the distance between starting position and ending position
    void Start()
    {
        xOffset = transform.position.x - TargetTransform.position.x;
        yOffset = transform.position.y - TargetTransform.position.y;
        zOffset = transform.position.z - TargetTransform.position.z;

        
    }

    //On update, moves camera to the new calculated position, which should keep player in the centre of camera
    void Update()
    {
        gameObject.transform.position = new Vector3
            (
            TargetTransform.position.x + xOffset,
            TargetTransform.position.y + yOffset,
            TargetTransform.position.z + zOffset
            );

    }
}
