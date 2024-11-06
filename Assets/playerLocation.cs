using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLocation : MonoBehaviour
{
    Transform location;
    // Start is called before the first frame update
    void Start()
    {
        location = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // Print the current location of the player
        Debug.Log(location.position);
    }
}
