using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private SpawnManager s;
    private UIManager _ui;
    void Start()
    {
        s = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        if (s == null)
        {
            Debug.LogError("Not Found Spawn");
        }
        _ui = GameObject.Find("Canvas").GetComponent<UIManager>();
        if (_ui == null)
        {
            Debug.Log("Null ui in Button");
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
    public void OnCubesButton()
    {
        Debug.Log("C");
        _ui.ForCubes();
    }
    public void OnShpereButton()
    {
        Debug.Log("S");
        _ui.ForSpheres();
    }
    public void OnCapsulesButton()
    {
        Debug.Log("Capp");
        _ui.ForCapsules();
    }
}
