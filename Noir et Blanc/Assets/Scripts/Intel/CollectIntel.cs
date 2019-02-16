using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectIntel : MonoBehaviour {

    void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.name == "Player")
        {
            Player.GetComponent<PlayerStats>().gotIntel();
            Destroy(gameObject);
        }
    }
}
