using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockRotation : MonoBehaviour {
    Transform t;
    public float fixedRotation = 0; 
	// Use this for initialization
	void Start () {
        t = transform;
	}
	
	// Update is called once per frame
	void Update () {
        t.eulerAngles = new Vector3(fixedRotation, t.eulerAngles.y, fixedRotation);
	}
}

//https://docs.unity3d.com/ScriptReference/Transform-eulerAngles.html
//http://answers.unity3d.com/questions/1302697/how-to-lock-the-rotation-of-an-object.html