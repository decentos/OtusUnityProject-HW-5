using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodEffectBehaviour : MonoBehaviour
{
    public ParticleSystem BloodParticles;
    
    public void PLayEffect()
    {
        BloodParticles.Play();
    }
    
}
