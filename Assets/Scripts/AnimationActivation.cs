using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationActivation : MonoBehaviour
{

    private Animation anim;
    public ParticleSystem thisParticle;

    void Start()
    {
        anim = GetComponent<Animation>();
    }


    void Update()
    {
        anim.Play("pepperShakeAnim");
        thisParticle.Play();
    }
}
