using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rigidBody = default;

    private bool collided = false;

    private void Update()
    {
        if (!collided && rigidBody.velocity.magnitude > 0)
        {
            transform.forward = rigidBody.velocity;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this);
    }
}
