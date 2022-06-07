using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;

public class ButtonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private SpawnManager s;
    void Start()
    {
        s = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        if (s == null)
        {
            Debug.LogError("Not Found Spawn");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CubeButtonClicked()
    {
        s.SpawnCube();
    }
    public void CapsuleButtonClicked()
    {
        s.SpawnCapsule();
    }
    public void SphereButtonClicked()
    {
        s.SpawnSphere();
    }
}
