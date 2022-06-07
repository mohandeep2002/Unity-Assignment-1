using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    Rigidbody rg;
    SpawnManager si;
    private void Start()
    {
        rg = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.tag);
        if (collision.transform.tag == "Capsule_Prefab")
        {
            //Debug.Log(collision.rigidbody.velocity);
            //Debug.Log(rg.velocity);
            if (rg.velocity.x < collision.rigidbody.velocity.x)
            {
                Debug.Log("This object");
                Destroy(this.gameObject);
            }
            else
            {
                Debug.Log("Colleded");
                Destroy(collision.gameObject);
            }
        }
    }
    private void Update()
    {
        Vector3 newV = new Vector3(transform.position.x, transform.position.y, 0);
        transform.position = newV;
    }
}
