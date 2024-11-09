using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class zombieWalk : MonoBehaviour
{
    [SerializeField] private GameObject[] targetArr;
    private Transform target;
    public float speed = 1f;
    private Rigidbody rig;
    private int health = 2;
    
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        targetArr = GameObject.FindGameObjectsWithTag("MainCamera");
        target = targetArr[0].transform;
    }

    void FixedUpdate()
    {
        Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
        rig.MovePosition(pos);
        transform.LookAt(target);
    }

    void Update()   
    {
        //If collider isTrigger is hit with bullet tag then health --; 
        // if health == 0 then destroy zombie
    }
}
