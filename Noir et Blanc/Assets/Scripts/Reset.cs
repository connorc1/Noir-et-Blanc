using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
                int scene = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(scene, LoadSceneMode.Single);
        }
        else if(col.gameObject.tag == "Guard")
        {
            Destroy(col.gameObject);
            Debug.Log("guard is destroyed");
        }
    }
}
