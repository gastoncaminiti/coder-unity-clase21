using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ConsoleController : MonoBehaviour
{
    // Start is called before the first frame update
    public static event Action<int> onConsoleChange;
    
    private bool isOpen = false;

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("EN CONSOLA");
        if (Input.GetKeyDown(KeyCode.E) && !isOpen)
        {
            isOpen = true;
            onConsoleChange?.Invoke(2);
        }

        if (Input.GetKeyDown(KeyCode.Escape) && isOpen)
        {
            isOpen = false;
            onConsoleChange?.Invoke(0);
        }
    }
}
