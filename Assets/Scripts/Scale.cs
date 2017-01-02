using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour {
    public Camera mCamera;
    private float height;
    private float width;
    void Start() {
        height = mCamera.orthographicSize * 2.0f;
        width = height * Screen.height / Screen.width;
    }
	void Update () {
        transform.localScale = new Vector3(width/2, width / 2, width / 2);
    }
}
