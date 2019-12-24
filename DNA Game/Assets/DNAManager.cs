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

    }

    int currIndex = 0;

    //public void UpdateIndex()
    //{
    //    currIndex++;
    //    // Remove the letter on the screen
    //}

    // Takes in the letter of the button pressed
    public void EnterLetter(char letter)
    {
        char currLetter = finalString[currIndex];
        char oppositeChar = getOpposite(currLetter);

        // if button clicked is correct pair match
        if (letter == oppositeChar)
        {
            // remove nucleotide from list and remove display image and move to next char in finalString (***TODO***)
            // Cannot remove by index because the list gets updated every time nucleotide[0] is removed, 
            // so use nucleotide[0] to get the next nucleotide to remove. (works like a queue)
            Debug.Log("remove: " + nucleotides[0].nucleotide);
            nucleotides[0].RemoveNucleotide();  // remove the nucleotide display before removing from the queue
            nucleotides.Remove(nucleotides[0]); // remove the nucleotide from the nucleotides queue
            currIndex++;
            CheckEndGame();
        }
        // else
        // punish by 1 second (implement later)
    }

    public char getOpposite(char n)
    {
        if (n == 'A') {
            return 'T';
        }
        else if (n == 'T')
        {
            return 'A';
        }
        else if (n == 'C')
        {
            return 'G';
        }
        else
        {
            return 'C';
        }
    }

    char button_pressed;

    public void TaskOnClick_A()
    {
        Debug.Log("You pressed button A");
        button_pressed = 'A';
        EnterLetter(button_pressed);
        CheckEndGame();
    }

    public void TaskOnClick_T()
    {
        Debug.Log("You pressed button T");
        button_pressed = 'T';
        EnterLetter(button_pressed);
        CheckEndGame();
    }

    public void TaskOnClick_C()
    {
        Debug.Log("You pressed button C");
        button_pressed = 'C';
        EnterLetter(button_pressed);
        CheckEndGame();
    }

    public void TaskOnClick_G()
    {
        Debug.Log("You pressed button G");
        button_pressed = 'G';
        EnterLetter(button_pressed);
        CheckEndGame();
    }

    public void CheckEndGame()
    {
        // End the game if end of DNA string (finalString)
        if (currIndex >= finalString.Length)
        {
            Debug.Log("END OF DNA. END GAME.");
            // end game
            // stop listening to buttons
        }
    }

}
