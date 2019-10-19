using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Nucleotide
{
    public string nucleotide;
    private DNADisplay display;

    // Pass in a nucelotide char and DNADisplay d, create the objects, and display the objects
    public Nucleotide(string n, DNADisplay d)
    {
        nucleotide = n;
        display = d;
        display.SetDNA(n);
    }


}
