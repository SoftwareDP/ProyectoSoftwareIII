using UnityEngine;
using UnityEngine.UI;
using System.Collections;
 
public class TextTv : MonoBehaviour {
 
    public string myString;
    public Text myText;
    public float fadeTime;
    public bool displayInfo;
 
    // Use this for initialization
    void Start () {
     
        myText = GameObject.Find ("Text").GetComponent<Text> ();
        //Screen.showCursor = false;
        //Screen.lockCursor = true;
    }
     
    // Update is called once per frame
    void Update () 
    {
 
        FadeText ();
 
        /*if (Input.GetKeyDown (KeyCode.Escape)) 
         
                {
                        Screen.lockCursor = false;
                         
                }
                */
 
     
    }
 
  
 
    void FadeText ()
 
    {
 
 
        if(displayInfo)
        {
 
            myText.text = myString;
           
        }
     
      
     
 
    }
}