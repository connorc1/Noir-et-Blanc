using System.Collections;
using UnityEngine;

public class Items : MonoBehaviour
{
    public int item = 0;

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "Player")
        {
            if (item == 0)
            {
                col.gameObject.GetComponent<CurrentItem>().gotRadio();
            }
            else if (item == 1)
            {
                col.gameObject.GetComponent<CurrentItem>().gotGun();
            }
            Destroy(gameObject);
        }
    }

}
