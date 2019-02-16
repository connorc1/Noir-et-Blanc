using UnityEngine;
using System.Collections;

//This script goes on the Shadow in game.
public class HiddenEntirely : MonoBehaviour
{
    public int number = 0;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            if (col.GetType().ToString() == "UnityEngine.CapsuleCollider")
            {
                col.GetComponent<PlayerStats>().enteredShadows();
                col.gameObject.transform.GetChild(0).GetComponent<Renderer>().material.color = Color.black;
            }
        }
        else if (col.gameObject.tag == "Guard")
        {
            if (number == 1)
            {
                if (col.GetType().ToString() == "UnityEngine.CapsuleCollider")
                {
                    col.gameObject.GetComponent<EnemyStats>().KILLGUARD();
                }
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            if (col.GetType().ToString() == "UnityEngine.CapsuleCollider")
            {
                col.GetComponent<PlayerStats>().exitedShadows();
                col.gameObject.transform.GetChild(0).GetComponent<Renderer>().material.color = Color.white;
            }
        }
    }
}
