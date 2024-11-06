using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantItems : MonoBehaviour
{
    BoxCollider col;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Green")
        {
            Debug.Log("Green item detected");
            other.GetComponent<Collider>().enabled = false;
            Destroy(other.gameObject, 1f);
        }
    }
}
