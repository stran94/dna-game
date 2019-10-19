using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class DNADisplay : MonoBehaviour
{
    public Image img;
    public GameObject dnaImg;
    public GameObject canvas;

    public void SetDNA (string nuc)
    {
        Debug.Log("DNADisplay: " + nuc);
        //var createImg = Instantiate(img) as Image;
        //img = GameObject.Instantiate(Resources.Load("blue")) as Image;
        //img.transform.SetParent(canvas.transform, false);
        //img.Image = Image.;

        Sprite blue = Resources.Load<Sprite>("blue");
        Sprite yellow = Resources.Load<Sprite>("yellow");
        Sprite green = Resources.Load<Sprite>("green");
        Sprite red = Resources.Load<Sprite>("red");

        // Delete this when you know it's working :)
        if (Debug.isDebugBuild)
        {
            Debug.Log("blue = " + blue);
            Debug.Log("yellow = " + yellow);
            Debug.Log("green = " + green);
            Debug.Log("red = " + red);
        }

        if (nuc == "A")
        {
            //img = GameObject.Instantiate(Resources.Load("blue")) as Image;
            gameObject.GetComponent<Image>().sprite = blue;
        }
        else if (nuc == "T")
        {
            //img = GameObject.Instantiate(Resources.Load("yellow")) as Image;
            gameObject.GetComponent<Image>().sprite = yellow;
        }
        else if (nuc == "C")
        {
            //img = GameObject.Instantiate(Resources.Load("green")) as Image;
            gameObject.GetComponent<Image>().sprite = green;
        }
        else
        {
            //img = GameObject.Instantiate(Resources.Load("red")) as Image;
            gameObject.GetComponent<Image>().sprite = red;
        }
        //img.transform.SetParent(canvas.transform, false);
    }

    /*public void CreateImg()
    {
        var createImg = Instantiate(dnaImg) as GameObject;
        createImg.transform.SetParent(canvas.transform, false);
    }*/
}
