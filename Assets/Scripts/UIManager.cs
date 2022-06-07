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
    [SerializeField]
    private GameObject cubePrefab, capsulePrefab, spherePrefab;
    private int cc, sc, ccc;
    void Start()
    {
        cc = 0;
        sc = 0;
        ccc = 0;
        cubePrefab.GetComponent<Renderer>().sharedMaterial.color = Color.red;
        spherePrefab.GetComponent<Renderer>().sharedMaterial.color = Color.blue;
        capsulePrefab.GetComponent<Renderer>().sharedMaterial.color = Color.green;
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
    public void ForCubes()
    {
        Debug.Log("forcubes");
        cc++;
        if (cc % 2 == 0)
        {
            cubePrefab.GetComponent<Renderer>().sharedMaterial.color = Color.red;
        }
        else
        {
            if (spherePrefab.GetComponent<Renderer>().sharedMaterial.color == Color.black)
            {
                spherePrefab.GetComponent<Renderer>().sharedMaterial.color = Color.blue;
                sc++;
            }
            if (capsulePrefab.GetComponent<Renderer>().sharedMaterial.color == Color.black)
            {
                capsulePrefab.GetComponent<Renderer>().sharedMaterial.color = Color.green;
                ccc++;
            }
            cubePrefab.GetComponent<Renderer>().sharedMaterial.color = Color.black; 
        }
        

    }
    public void ForSpheres()
    {
        Debug.Log("forspheres");
        sc++;
        if (sc % 2 == 0)
        {
            spherePrefab.GetComponent<Renderer>().sharedMaterial.color = Color.blue;
        }
        else
        {
            if (cubePrefab.GetComponent<Renderer>().sharedMaterial.color == Color.black)
            {
                cubePrefab.GetComponent<Renderer>().sharedMaterial.color = Color.red;
                cc++;
            }
            if (capsulePrefab.GetComponent<Renderer>().sharedMaterial.color == Color.black)
            {
                capsulePrefab.GetComponent<Renderer>().sharedMaterial.color = Color.green;
                ccc++;
            }
            spherePrefab.GetComponent<Renderer>().sharedMaterial.color = Color.black;
        }

    }
    public void ForCapsules()
    {
        Debug.Log("forcapsules");
        ccc++;
        if (ccc % 2 == 0)
        {
            capsulePrefab.GetComponent<Renderer>().sharedMaterial.color = Color.green;
        }
        else
        {
            if (cubePrefab.GetComponent<Renderer>().sharedMaterial.color == Color.black)
            {
                cubePrefab.GetComponent<Renderer>().sharedMaterial.color = Color.red;
                cc++;
            }
            if (spherePrefab.GetComponent<Renderer>().sharedMaterial.color == Color.black)
            {
                spherePrefab.GetComponent<Renderer>().sharedMaterial.color = Color.blue;
                sc++;
            }
            capsulePrefab.GetComponent<Renderer>().sharedMaterial.color = Color.black;
        }
    }
}
