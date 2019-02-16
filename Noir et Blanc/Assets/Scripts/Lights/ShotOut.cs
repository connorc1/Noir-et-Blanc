using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotOut : MonoBehaviour {
    public GameObject player;

	void OnMouseDown()
    {
        if (player.gameObject.GetComponent<PlayerStats>().ammo > 0)
        {
            Destroy(gameObject);
            player.gameObject.GetComponent<PlayerStats>().ammo--;
        }
    }
}
