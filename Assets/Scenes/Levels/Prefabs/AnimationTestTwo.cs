using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationTestTwo : MonoBehaviour
{
    public AnimationCurve _ac;
    public Animation _animation;
    public Animator _animator;
    public Sprite sprite1;
    public bool ifEventOccured = false;

    // Start is called before the first frame update
    void Start()
    {
        _ac = new AnimationCurve(new Keyframe(1, 1), new Keyframe(2,2));
        _animation = this.gameObject.GetComponent<Animation>();
        //_animation.Play("AnimationCurve001");
        _animator = this.gameObject.GetComponent<Animator>();
        //_animator.Play("AnimationCurve001");
        _animator.enabled = true;
        Debug.Log(_animator.runtimeAnimatorController.name + "Name");
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnAnimationEve()
    {
        ifEventOccured = true;
        this.gameObject.GetComponent<Image>().sprite = sprite1;
        
    }


}
