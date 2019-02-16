using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Detection : MonoBehaviour
{
    private Vector3 lefteye;
    private Vector3 righteye;
    private GameObject holder;
    private RaycastHit hit;
    
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "Radio")// || col.gameObject.name == "Radio" || col.GetComponent<EnemyStats>().getLife() == false)
        {
            this.GetComponent<EnemyStats>().alert();
        }
        else if(col.gameObject.name == "Player")
        {
            if (col.GetType().ToString() == "UnityEngine.CapsuleCollider")
            {
                if (col.gameObject.GetComponent<PlayerStats>().getHidden() == false)
                {
                    if (this.GetComponent<EnemyStats>().isAlive == true)
                    {
                        int scene = SceneManager.GetActiveScene().buildIndex;
                        SceneManager.LoadScene(scene, LoadSceneMode.Single);
                    }
                }
            }
        }
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            if (col.GetType().ToString() == "UnityEngine.CapsuleCollider")
            {
                if (col.gameObject.GetComponent<PlayerStats>().getHidden() == false)
                {
                    if (this.GetComponent<EnemyStats>().isAlive == true)
                    {
                        int scene = SceneManager.GetActiveScene().buildIndex;
                        SceneManager.LoadScene(scene, LoadSceneMode.Single);
                    }
                }
            }
        }
    }
}
/*Reference
 * https://docs.unity3d.com/ScriptReference/Transform.LookAt.html
 * https://docs.unity3d.com/ScriptReference/GameObject.GetComponent.html
 * http://answers.unity3d.com/questions/64395/reload-current-level-when-i-die.html
 * https://docs.unity3d.com/ScriptReference/Physics.Raycast.html
 * https://docs.unity3d.com/ScriptReference/Transform.GetChild.html
 * 
 */
