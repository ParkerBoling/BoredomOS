using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    public GameObject Window;

    private void Awake()
    {
        Destroy(Window);
    }
}
