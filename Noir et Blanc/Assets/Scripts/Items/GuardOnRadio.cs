using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardOnRadio : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Guard")
        {
            col.gameObject.GetComponent<EnemyStats>().isThereNow();
        }
    }
}
