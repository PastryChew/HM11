using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationController : MonoBehaviour
{

    public AnimationClip[] clips;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

    }

    public void RandomAnimationPlay()
    {
        int Rand = Random.Range(0, clips.Length);
        animator.Play(clips[Rand].name);
    }

}
