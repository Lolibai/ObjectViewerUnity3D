using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayAnimation : MonoBehaviour {
    public Button button; //assing button object
    void Start() {
        Button btn = button.GetComponent<Button>(); //get button
        btn.onClick.AddListener(TaskOnClick);       //do Action on click
    }
    void TaskOnClick () {
        GameObject.FindGameObjectWithTag("MyObjects").GetComponent<Rotate>().enabled = !GameObject.FindGameObjectWithTag("MyObjects").GetComponent<Rotate>().enabled; //do iverse (toggle), disable script
    }
}
