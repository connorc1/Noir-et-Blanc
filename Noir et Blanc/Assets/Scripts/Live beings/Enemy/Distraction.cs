using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distraction : MonoBehaviour
{
    public bool isGuard = false;
    public bool isRadio = false;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Guard")
        {
            col.GetComponent<EnemyStats>().changeDistract();
        }
    }
}
