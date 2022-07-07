using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellFactory : MonoBehaviour
{
    public GameObject shellPrefab;
    
    public Shell Create()
    {
        GameObject shellGo = Instantiate(shellPrefab);
        Shell shell = new Shell(shellGo);
        return shell;
    }
}
