using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class End : MonoBehaviour {
    private PlayerStats stats;
    public string nextLevelName;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            stats = col.gameObject.GetComponent<PlayerStats>();
            if (stats.intelLeft == 0)
            {
                SceneManager.LoadScene(nextLevelName, LoadSceneMode.Single);
            }
        }
    }
}
//https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadScene.html