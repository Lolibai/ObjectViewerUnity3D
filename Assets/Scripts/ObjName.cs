using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjName : MonoBehaviour {

    public Text text;
    private GameObject temp;

	void Update(){
        text.text = ""; //empty label when no selection
        if (GameObject.FindGameObjectWithTag("MyObjects") != null)
        {
            temp = GameObject.FindGameObjectWithTag("MyObjects"); //find by tag
            temp.name = temp.name.Replace("(Clone)", "");// remove endings (clone)
            text.text = temp.name; //assign name
        }
	}
}
