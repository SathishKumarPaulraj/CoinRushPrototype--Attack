using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationCurveConstructor : MonoBehaviour
{

    public AnimationCurve animCurve;
    private Vector3 initialValue;
    public float graphValue;
    public Sprite Sprite1, Sprite2;


    public void Awake()
    {
        animCurve.postWrapMode = WrapMode.PingPong;
        Debug.Log(initialValue);
        initialValue = Vector3.one;
        Debug.Log(initialValue);
       // finalPosition = initialPosition + new Vector3(20f, 0, 0f);
    }

    // Start is called before the first frame update
    void Start()
    {
       // StartCoroutine(MoveObject());
      
    }

    // Update is called once per frame
    void Update()
    {
       
        graphValue = animCurve.Evaluate(Time.time);
        transform.localScale = initialValue * graphValue;
        if (graphValue > .5)
        {
            this.GetComponent<Image>().sprite = Sprite1;
            Debug.Log("Greater than .5");
        }
        else
        {
            this.GetComponent<Image>().sprite = Sprite2;
            Debug.Log("less than .5");
        }
    }

  /*  private IEnumerator MoveObject()
    {
        float i = 0;
        float rate = 1 / .5f;
        while (i < 1)
        {
            i += rate * Time.deltaTime;
            finalPosition += initialPosition * 2 * Time.deltaTime;
            transform.localPosition = Vector3.Lerp(initialPosition, finalPosition, AnimCurve.Evaluate(i));
            yield return 0;
        }
    }
  */
}
