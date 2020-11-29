using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animation))]

public class AnimationPlayer : MonoBehaviour
{
    [SerializeField] AnimationClip _clip;

    Animation _animComp;

    private void Awake()
    {
        _animComp = GetComponent<Animation>();
    }

    public void PlayClip()
    {
        _animComp.clip = _clip;
        _animComp.Play();
    }
}
