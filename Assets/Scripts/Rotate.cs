using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{
    /// <summary>
    /// SIMPLE CODED ANIMATION, I could use animations and animators but I dont have clips :(
    /// </summary>
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}