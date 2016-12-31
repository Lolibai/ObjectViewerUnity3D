using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayAnimation : MonoBehaviour {
    public Button button;
    // Update is called once per frame
    void Start() {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick () {
        GameObject.FindGameObjectWithTag("MyObjects").GetComponent<Rotate>().enabled = !GameObject.FindGameObjectWithTag("MyObjects").GetComponent<Rotate>().enabled;
    }
}
