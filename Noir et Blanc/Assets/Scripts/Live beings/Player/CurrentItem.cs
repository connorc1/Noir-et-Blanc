using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentItem : MonoBehaviour
{
    private bool hasPistol;
    private bool hasRadio;

    public void gotGun()
    {
        hasPistol = true;
    }
    public void gotRadio()
    {
        hasRadio = true;
    }
    
}
