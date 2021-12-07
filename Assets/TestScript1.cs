using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript1 : MonoBehaviour
{
    public Sprite spriteToChange;
    public Image sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = this.gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            sprite.sprite = Resources.Load("Coin") as Sprite;
        }

    }
    public void OnAnim()
    {
        sprite.sprite = Resources.Load("Coin") as Sprite;
    }
}
