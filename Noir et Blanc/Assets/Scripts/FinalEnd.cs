using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalEnd : MonoBehaviour {
    private PlayerStats stats;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            stats = col.gameObject.GetComponent<PlayerStats>();
            if (stats.intelLeft == 0)
            {
                Application.Quit();
            }
        }
    }
}
