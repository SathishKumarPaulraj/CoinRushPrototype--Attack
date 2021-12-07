using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationTest : MonoBehaviour
{

    public AnimationCurve _animationCurve;
       
    private Vector3 initialValue;
    public float graphValue;
    public Sprite sprite1, sprite2;

    private void Awake()
    {
        Debug.Log(_animationCurve.length + " Length ");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError("worked");
        initialValue = Vector3.one;
        _animationCurve.postWrapMode = WrapMode.PingPong;
    }

    // Update is called once per frame
    void Update()
    {
        graphValue = _animationCurve.Evaluate(Time.time);
      //  transform.localScale = initialValue * graphValue;
        if (graphValue > .5)
        {
            this.GetComponent<Image>().sprite = sprite1;
            Debug.LogError(" entered into Sprite");
        }
        else
        {
            this.GetComponent<Image>().overrideSprite = null;
        }
    }
}
