using UnityEngine;


public class FireEffectBehaviour : MonoBehaviour
{
    public ParticleSystem FireParticles;

    public void PlayFireEffect()
    {
        FireParticles.Play();
    }
}
