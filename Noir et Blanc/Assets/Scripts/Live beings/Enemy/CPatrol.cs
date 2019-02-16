using System.Collections;
using UnityEngine;

public class CPatrol : MonoBehaviour
{
    public GameObject nextPoint;
    public GameObject previousPoint;
    public bool end;
    
    public GameObject nextPatrol(bool reverse)
    {
        if(reverse == false)
        {
            return nextPoint;
        }
        else
        {
            return previousPoint;
        }
    }
}
