using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject cubeT, capT, sphT;
    [SerializeField]
    private GameObject cubeParent, capsuleParent, sphereParent;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cubeParent.transform.childCount < 1)
        {
            cubeT.SetActive(false);
        }
        if (capsuleParent.transform.childCount < 1)
        {
            capT.SetActive(false);
        }
        if (sphereParent.transform.childCount < 1)
        {
            sphT.SetActive(false);
        }
    }
    public void OnCubeT()
    {
        cubeT.SetActive(true);
    }
    public void OnCapT()
    {
        capT.SetActive(true);
    }
    public void OnSphT()
    {
        sphT.SetActive(true);
    }
}
