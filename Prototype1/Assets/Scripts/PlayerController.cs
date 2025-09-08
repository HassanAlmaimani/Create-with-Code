using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Adjust this value to change the car's speed
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Moves the car forward at a constant speed
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
