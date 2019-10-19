using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DNAManager : MonoBehaviour
{

    public List<Nucleotide> nucleotides;

    public DNASpawner dnaSpawner;

    public Button A_Button, T_Button, C_Button, G_Button;

    String finalString;

    // Start is called before the first frame update
    private void Start()
    {
        CreateDNA();
        A_Button.onClick.AddListener(TaskOnClick_A);
        T_Button.onClick.AddListener(TaskOnClick_T);
        C_Button.onClick.AddListener(TaskOnClick_C);
        G_Button.onClick.AddListener(TaskOnClick_G);
    }

    public void CreateDNA()
    {
        var chars = "ATCG";
        var stringChars = new char[8];
        var random = new System.Random();

        for (int i = 0; i < stringChars.Length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
            Nucleotide nucleotide = new Nucleotide(System.Char.ToString(stringChars[i]), dnaSpawner.SpawnDNA());
            //Nucleotide nucleotide = new Nucleotide(System.Char.ToString(stringChars[i]));
            Debug.Log(nucleotide.nucleotide);
            nucleotides.Add(nucleotide);

            finalString += System.Char.ToString(stringChars[i]);
        }

        Debug.Log("FINAL STRING: " + finalString);

        //var finalString = new String(stringChars);
        //Console.WriteLine(finalString + "ASJDLASJDLKJALSDS");

    }

    // Takes in the letter of the button pressed
    public void EnterLetter(char letter)
    {
        // for each letter in stringChars
            // if button clicked is correct pair match
                // remove nucleotide from list and remove display image
            // else
                // punish by 1 second (implement later)
    }

    char button_pressed;

    public void TaskOnClick_A()
    {
        Debug.Log("You pressed button A");
        button_pressed = 'A';
        EnterLetter(button_pressed);
    }

    public void TaskOnClick_T()
    {
        Debug.Log("You pressed button T");
        button_pressed = 'T';
        EnterLetter(button_pressed);
    }

    public void TaskOnClick_C()
    {
        Debug.Log("You pressed button C");
        button_pressed = 'C';
        EnterLetter(button_pressed);
    }

    public void TaskOnClick_G()
    {
        Debug.Log("You pressed button G");
        button_pressed = 'G';
        EnterLetter(button_pressed);
    }

}
