using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationScript : MonoBehaviour
{

    public Sprite _sprite1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintFloat()
    {
        Debug.Log("PrintFloat is called with a value of " );
        this.gameObject.GetComponent<Image>().overrideSprite = _sprite1;
       // this.gameObject.GetComponent<Image>().enabled = false;
    }
    public void PrintFloatCheck()
    {
        Debug.Log("PrintFloat is called with a value of ");
        this.gameObject.GetComponent<Image>().overrideSprite = null ;
        // this.gameObject.GetComponent<Image>().enabled = false;
    }

}
