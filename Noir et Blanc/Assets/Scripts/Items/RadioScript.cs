using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioScript : MonoBehaviour {

	private GameObject OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Guard")
        {
            col.gameObject.GetComponent<EnemyStats>().provideDistractor(this.gameObject);
            return this.gameObject;
        }
        return null;
    }
}
