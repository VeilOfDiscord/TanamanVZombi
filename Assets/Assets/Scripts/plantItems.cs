using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantItems : MonoBehaviour
{
    private BoxCollider col;
    [SerializeField] private Vector3 pos;

    [SerializeField] private GameObject Tree;

    private bool hasSeed = false;
    private bool hasWater = false;
    private bool hasPowder = false;
    private bool plantGrown = false;

    // Start is called before the first frame update
    void Awake()
    {
        col = GetComponent<BoxCollider>();
        Vector3 pos = gameObject.transform.position;

    }

    void Update()
    {
        // Debug.Log("Seed Status: "+ hasSeed);
        // Debug.Log("Water Status: "+ hasWater);
        // Debug.Log("Powder Status: "+ hasPowder);

        if(hasSeed && hasWater && hasPowder && !plantGrown)
        {
            growPlant();
            plantGrown = true;
        }
    }

    private void growPlant()
    {
        Instantiate(Tree, pos, Quaternion.identity);
        // Debug.Log("Planting tree at:" + pos);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Green" && !hasSeed)
        {
            // Debug.Log("Green item detected");
            hasSeed = true;

            other.GetComponent<Collider>().enabled = false;

            Destroy(other.gameObject, 1f);
        }
        // else{Debug.Log("Wrong object or already has item");};

        if(other.tag == "Water" && !hasWater)
        {
            // Debug.Log("Water item detected");
            hasWater = true;

            other.GetComponent<Collider>().enabled = false;

            Destroy(other.gameObject, 1f);
        }
        // else{Debug.Log("Wrong object or already has item");};

        if(other.tag == "Powder" && !hasPowder) 
        {
            // Debug.Log("Powder item detected");
            hasPowder = true;

            other.GetComponent<Collider>().enabled = false;

            Destroy(other.gameObject, 1f);
        }
        // else{Debug.Log("Wrong object or already has item");};

    }
}
