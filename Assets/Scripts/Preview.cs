using UnityEngine.UI;
using UnityEngine;
using System.Threading;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class Preview : MonoBehaviour {

    public Button button; //get button which is selected
    public GameObject target; //get object to work with
    public Image image;       //get image placeholder
    public Text text;         //get text placeholder
    private Sprite mySprite;  //image takes sprites? for converting Texture2d to sprite

    void Start () {
        Button btn = button.GetComponent<Button>(); //button action
        btn.onClick.AddListener(TaskOnClick);       //button action

        int counter = 0;
        Texture2D t2 = null;    //texture
        #if UNITY_EDITOR
        while (t2 == null && counter < 75)
        {
            t2 = AssetPreview.GetAssetPreview(target);          //get that preview icon
            counter++;                                          //it must w8
            Thread.Sleep(15);                                   //it must w8
        }
        #endif
        mySprite = Sprite.Create(t2, new Rect(0, 0, 120, 120), new Vector2(120, 120)); //create sprite
        image.sprite = mySprite;                                                       //assign sprite

        text.text = target.name;                                                       //object name 
    }
    public void DeleteAll()//Alternative Refresh()
    {
        foreach (GameObject o in GameObject.FindGameObjectsWithTag("MyObjects"))        
        {
            Destroy(o);
        }
    }
    void TaskOnClick()//Button Action
    {
        DeleteAll();
        Debug.Log("You have clicked the button!");

        var instantiatedPrefab = Instantiate(target, new Vector3(20,5,90), Quaternion.identity); //create prefab on click
        instantiatedPrefab.transform.localScale = new Vector3(20, 20, 20); //scale object
        if (instantiatedPrefab != null) Debug.Log("Prefab created"); //just for fun :D 
    }
}