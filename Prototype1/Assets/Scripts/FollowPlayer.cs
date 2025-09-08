using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; // Reference to the player GameObject

    // A private variable to hold the offset distance between the camera and the car
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // Calculate the initial offset
        // This makes sure the camera stays at the same relative distance from the car
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Update the camera's position to follow the car, maintaining the initial offset
        transform.position = player.transform.position + offset;
    }
}
