using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNASpawner : MonoBehaviour
{

    public GameObject DNAPrefab;
    public Transform DNACanvas;

    // create DNA prefab object and return a DNADisplay
    public DNADisplay SpawnDNA()
    {
        GameObject dnaObj = Instantiate(DNAPrefab, DNACanvas);
        DNADisplay dnaDisplay = dnaObj.GetComponent<DNADisplay>();

        return dnaDisplay;
    }

}
