using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyStats : MonoBehaviour
{
    private bool chamberedRound = false;
    public bool isAlive = true;
    public bool isDistracted = false;
    private bool isThere = false;
    private float distractTime = 7.0f;
    public bool isStationary = false;

    public bool reverse = false;
    public float speed = 1;
    public GameObject current;
    private GameObject goTo;
    private GameObject distractor;
    //public int awareSize;
    //public int foundSize;

    private void Start()
    {
        CPatrol patrol = current.GetComponent<CPatrol>();
        if (isStationary == false)
        {
            goTo = patrol.nextPatrol(false);
        }
        
    }

    private void Update()
    {
        if(isAlive)
        {
            makePatrol();
        }
    }

    void makePatrol()
    {
        if (isDistracted == false)
        {
            if (isStationary != true)
            {
                float step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, goTo.transform.position, step);
                transform.rotation = Quaternion.LookRotation(goTo.transform.position - transform.position);
                if (transform.position == goTo.transform.position)
                {
                    CPatrol patrol = goTo.GetComponent<CPatrol>();
                    if (patrol.end == true)
                    {
                        patrolReturn();
                    }
                    current = goTo;
                    goTo = patrol.nextPatrol(reverse);
                }
            }
            else if (transform.position != current.transform.position)
            {
                float step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, current.transform.position, step);
            }
        }
        else
        {
            if (distractor == null)
            {
                isDistracted = false;
            }
            else
            {
                if (isThere == false)
                {
                    float step = speed * Time.deltaTime;
                    transform.position = Vector3.MoveTowards(transform.position, distractor.transform.GetChild(3).transform.position, step);
                }
                if (isThere)
                {
                    distractTime -= Time.deltaTime;
                    if (distractTime <= 0)
                    {
                        isDistracted = false;
                        distractor = null;
                        isThere = false;
                    }
                }
            }            
        }
    }

    public void isThereNow()
    {
        isThere = true;
    }

    public void provideDistractor(GameObject radio)
    {
        isDistracted = true;
        distractor = radio;
    }

    public void patrolReturn()
    {
        if (reverse == true)
        {
            reverse = false;
        }
        else if (reverse == false)
        {
            reverse = true;
        }
    }

    public void changeDistract()
    {
        if(isDistracted == false)
        {
            isDistracted = true;
        }
    }

    public bool getLife()
    {
        if (isAlive == false)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void alert()
    {
        chamberedRound = true;
    }

    public void KILLGUARD()
    {
        isAlive = false;
        Rigidbody guard = GetComponent<Rigidbody>();
        guard.constraints = RigidbodyConstraints.None;
        gameObject.GetComponent<CapsuleCollider>().enabled = false; 
    }
}
//http://answers.unity3d.com/questions/14279/make-an-object-move-from-point-a-to-point-b-then-b.html
//https://docs.unity3d.com/ScriptReference/Transform.Rotate.html

