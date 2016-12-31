using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjName : MonoBehaviour {

    public Text text;
    void Start()
    {

    }
	// Use this for initialization
	void Update(){
        text.text = "";
        GameObject temp = GameObject.FindGameObjectWithTag("MyObjects");
        temp.name = temp.name.Replace("(Clone)", "");
        text.text = temp.name;
	}
}
