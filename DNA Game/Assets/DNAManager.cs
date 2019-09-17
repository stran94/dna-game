using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DNAManager : MonoBehaviour
{

    public List<Nucleotide> nucleotides;

    // Start is called before the first frame update
    private void Start()
    {
        CreateDNA();
    }

    public void CreateDNA()
    {
        var chars = "ATCG";
        var stringChars = new char[8];
        var random = new System.Random();

        for (int i = 0; i < stringChars.Length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
            Nucleotide nucleotide = new Nucleotide(stringChars[i]);
            Debug.Log(nucleotide.nucleotide);
            nucleotides.Add(nucleotide);
        }

        var finalString = new String(stringChars);
        Console.WriteLine(finalString);

    }

}
