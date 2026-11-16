using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTester : MonoBehaviour
{
    public Vector3 velocity;

    private void OnCollisionEnter(Collision col) //Collision data - surface contact points, velocity and angles
    {
        Debug.Log(gameObject.name + "has collided with" + col.gameObject.name);
    }

    private void OnTriggerEnter(Collider other) //Trigger data is overlap only
    {
        Debug.Log(gameObject.name + "was triggered by" + other.gameObject.name);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(GetComponent<Rigidbody>() == null || GetComponent<Rigidbody>().isKinematic){
            //If no RigidBody or if it is Kinematic - use transform translate
            transform.Translate(velocity * Time.deltaTime);
        }
        else {
            //if RigidBody and Not IsKinematic
            //only move this object with stuff like:
            //this.rigidbody.addforce(...);
        }
    }
}
