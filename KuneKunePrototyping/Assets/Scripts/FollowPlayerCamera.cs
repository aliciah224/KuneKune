using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerCamera : MonoBehaviour
{
    public Transform TargetTransform;

    private float xOffset;
    private float yOffset;
    private float zOffset;

    void Start()
    {
        xOffset = transform.position.x - TargetTransform.position.x;
        yOffset = transform.position.y - TargetTransform.position.y;
        zOffset = transform.position.z - TargetTransform.position.z;

        
    }

    
    void Update()
    {
        gameObject.transform.position = new Vector3(
            TargetTransform.position.x + xOffset,
            TargetTransform.position.y + yOffset,
            TargetTransform.position.z + zOffset);

    }
}
