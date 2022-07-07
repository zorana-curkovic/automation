using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneTemplate;
using UnityEngine;

public class Shell
{
    public GameObject ShellObject;

    public bool HoldsPea
    {
        get;
        set;
    }

    public Shell(GameObject shellObject)
    {
        ShellObject = shellObject;
    }
}

public class ShellChef : MonoBehaviour
{
    public int numberOfShells;
    
    public ShellFactory factory;
    
    public Transform leftPlaceholder;

    public Transform midPlaceholder;

    public Transform rightPlaceholder;

    private Shell[] _shells;
    
    void Start()
    {
    }

    void Update()
    {
        
    }
    
    public void InitializeGame()
    {
        _shells = new Shell[numberOfShells];

        for (int i = 0; i < numberOfShells; ++i)
            _shells[i] = factory.Create();

    }
}
