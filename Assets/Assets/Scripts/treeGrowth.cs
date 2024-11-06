using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeGrowth : MonoBehaviour
{
    private float timer = 0f;
    public float growTime = 5f;
    public float maxSize = 2f;

    public bool isMaxSize = false;
    [SerializeField] private MeshFilter modelToChange;
    [SerializeField] private Mesh[] TreeModelsToUse;

    void Start()
    {
        replaceTree();

        if(isMaxSize == false)
        {
            StartCoroutine(Grow());
        }
    }

    private IEnumerator Grow()
    {
        Vector3 startScale = transform.localScale;
        Vector3 maxScale = new Vector3(maxSize, maxSize, maxSize);
        
        do{
            transform.localScale = Vector3.Lerp(startScale, maxScale, timer / growTime);
            timer += Time.deltaTime;
            yield return null;
        }
        while (timer < growTime);

        isMaxSize = true;
    }

    private void replaceTree()
    {
        int index = UnityEngine.Random.Range(0, TreeModelsToUse.Length);

        modelToChange.mesh = TreeModelsToUse[index];
    }
}
