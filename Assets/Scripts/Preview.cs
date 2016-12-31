using UnityEngine.UI;
using UnityEditor;
using UnityEngine;
using System.Threading;
using System.IO;

public class Preview : MonoBehaviour {

    public Button button;
    public GameObject target;
    public Image image;
    public Text text;
    private Sprite mySprite;

    // Use this for initialization
    void Start () {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        int counter = 0;
        Texture2D t2 = AssetPreview.GetAssetPreview(target);
        while (t2 == null && counter < 75)
        {
            t2 = AssetPreview.GetAssetPreview(target);
            counter++;
            Thread.Sleep(15);
        }
        mySprite = Sprite.Create(t2, new Rect(0, 0, 120, 120), new Vector2(120, 120));
        image.sprite = mySprite;

        text.text = target.name;
    }
    public void DeleteAll()
    {
        foreach (GameObject o in GameObject.FindGameObjectsWithTag("MyObjects"))
        {
            Destroy(o);
        }
    }
    void TaskOnClick()
    {
        DeleteAll();
        Debug.Log("You have clicked the button!");

        var instantiatedPrefab = Instantiate(target, new Vector3(10,0,90), Quaternion.identity);
        instantiatedPrefab.transform.localScale = new Vector3(15, 15, 15);
        if (instantiatedPrefab != null) Debug.Log("Prefab created");
    }
}