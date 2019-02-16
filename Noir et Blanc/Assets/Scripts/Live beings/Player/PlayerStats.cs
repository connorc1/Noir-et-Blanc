using UnityEngine;
using System.Collections;

[System.Serializable]
public class PlayerStats : MonoBehaviour
{
    public bool inShadows = false;
    public int ammo = 0;
    public int radio = 0;
    public int intelLeft = 0;
    public int shadows = 0;
    public float placementDelay = 0.0f;
    public GameObject radioHolder;
    public Transform spawnpoint;

     /*These functions are used to set the player to be in the
     *shadows. */
    public void enteredShadows()
    {
        inShadows = true;
        gameObject.transform.GetChild(5).gameObject.GetComponent<Light>().enabled = false;
        shadows++;
    }

    void Update()
    {
        placementDelay -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (radio > 0)
            {
                if (placementDelay <= 0)
                {
                    radio--;
                    Instantiate(radioHolder, spawnpoint.position, spawnpoint.rotation);
                    placementDelay = 2.0f;
                }
            }
        }
    }

    /*These functions are used to set the player to be outside
     * of the shadows */
    public void exitedShadows()
    {
        shadows--;
        if (shadows == 0)
        {
            inShadows = false;
            gameObject.transform.GetChild(5).gameObject.GetComponent<Light>().enabled = true;
        }  
    }
    
    public bool getHidden()
    {
        return inShadows;
    }

    public void gotIntel()
    {
        intelLeft--;
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Radio")
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                if (col.GetType().ToString() == "UnityEngine.BoxCollider")
                {
                    Destroy(col.gameObject);
                    radio = radio + 1;
                }
            }
        }
        else if (col.gameObject.tag == "Gun")
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                    Destroy(col.gameObject);
                    ammo = ammo + 1;
            }
        }
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Guard")
        {
            if (col.GetType().ToString() == "UnityEngine.CapsuleCollider")
            {
                col.gameObject.GetComponent<EnemyStats>().KILLGUARD();
            }
        }
    }
}
//http://answers.unity3d.com/questions/23326/syntax-to-get-the-type-of-collider.html
