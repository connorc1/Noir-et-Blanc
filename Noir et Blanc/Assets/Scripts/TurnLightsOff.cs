using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLightsOff : MonoBehaviour {
    public GameObject light;
    public GameObject shadow;
    bool destroyed = false;

	void OnTriggerEnter(Collider col)
    {
        if (col.GetType().ToString() == "UnityEngine.CapsuleCollider")
        {
            if (destroyed == false)
            {
                Destroy(light);
                shadow.gameObject.active = true;
                destroyed = true;
            }
        }
    }
}
