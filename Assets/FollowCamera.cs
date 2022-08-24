using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
        // For the camera to follow around the player

    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0,0, -10);
    }
}