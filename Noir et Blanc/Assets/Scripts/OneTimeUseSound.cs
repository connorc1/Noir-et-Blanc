using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneTimeUseSound : MonoBehaviour {
    public AudioClip item;
    private AudioSource source;
    public int maxNumberOfPlays = 1;
    private int hasPlayed = 0;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            if (hasPlayed < maxNumberOfPlays)
            {
                source = col.gameObject.GetComponent<AudioSource>();
                source.PlayOneShot(item, 0.6f);
                hasPlayed++;
            }
        }
    }
}
