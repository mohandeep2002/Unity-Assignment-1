using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField]
    private GameObject cube, sphere, capsule;
    [SerializeField]
    private GameObject cubeparent, sphereparent, capsuleparent;
    private UIManager _ui;
    private void Start()
    {
        _ui = GameObject.Find("Canvas").GetComponent<UIManager>();
        if (_ui == null)
        {
            Debug.Log("Null ui in spawn");
        }
    }
    public void SpawnCube()
    {
        Vector3 newVector = new Vector3(Random.Range(-9.26f, 9f), Random.Range(4.8f, -4.6f), 0);
        GameObject spawn = Instantiate(cube, newVector, Quaternion.LookRotation(new Vector3(0.18f, -0.24f, 0)));
        // GameObject spawn = Instantiate(cube, newVector, Quater);
        spawn.transform.parent = cubeparent.transform;
        _ui.OnCubeT();
    }
    public void SpawnSphere()
    {
        Vector3 newVector = new Vector3(Random.Range(-9.26f, 9f), Random.Range(4.8f, -4.6f), 0);
        GameObject spawn  = Instantiate(sphere, newVector, Quaternion.LookRotation(newVector));
        spawn.transform.parent = sphereparent.transform;
        _ui.OnSphT();
    }
    public void SpawnCapsule()
    {
        Vector3 newVector = new Vector3(Random.Range(-9.26f, 9f), Random.Range(4.8f, -4.6f), 0);
        GameObject spawn = Instantiate(capsule, newVector, Quaternion.LookRotation(newVector));
        spawn.transform.parent = capsuleparent.transform;
        _ui.OnCapT();
    }
}