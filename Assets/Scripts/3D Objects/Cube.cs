using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    Rigidbody rg;
    private void Start()
    {
        rg = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    { 
        Debug.Log(collision.transform.tag);
        if (collision.transform.tag == "Cube_Prefab")
        {
            //Debug.Log(collision.rigidbody.velocity);
            //Debug.Log(rg.velocity);
            Debug.Log(rg.velocity.x+" " + rg.velocity.y+ " "+ rg.velocity.z);
            Debug.Log(collision.rigidbody.velocity.x + " " + collision.rigidbody.velocity.y + " " + collision.rigidbody.velocity.z);
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
    IEnumerator Deleting()
    {
        yield return new WaitForSeconds(3f);
    }
}
