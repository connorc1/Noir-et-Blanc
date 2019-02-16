using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {
    public GameObject TeleTo;

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "Player")
        {
            col.gameObject.transform.position = TeleTo.transform.position;
        }
    }
}
