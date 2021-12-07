using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JokerAnimationScript : MonoBehaviour
{
    public Sprite sprite1;
    public GameObject obj1,obj2,obj3;

    // Start is called before the first frame update
    void Start()
    {
        obj1 = this.gameObject.transform.GetChild(8).gameObject;
        obj2 = this.gameObject.transform.GetChild(9).gameObject;
        obj3 = this.gameObject.transform.GetChild(10).gameObject;
        Debug.Log(obj1.name);
        Debug.Log(obj2.name);
        Debug.Log(obj3.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JokerChange()
    {
        obj2.GetComponent<Image>().sprite = sprite1;
       // this.gameObject.transform.GetChild(9).gameObject.GetComponent<Image>().overrideSprite = sprite1;
    }
    public void CardDelete()
    {
        obj1.GetComponent<Image>().enabled = false;
        obj3.GetComponent<Image>().enabled = false;
    }

}
