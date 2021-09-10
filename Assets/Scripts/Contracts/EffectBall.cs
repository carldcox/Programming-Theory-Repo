using System;
using UnityEngine;

namespace Contracts
{
    [RequireComponent(typeof(ParticleSystem))]
    public class EffectBall : Ball, IEffect
    {
        protected ParticleSystem EffectParticleSystem;

        public void PlayParticle()
        {
            EffectParticleSystem.Play();
        }

        public void PlayRepeatingParticle()
        {
            throw new System.NotImplementedException();
        }

        public void StopParticle()
        {
            EffectParticleSystem.Stop();
        }

        protected void Awake()
        {
            base.Awake();
            EffectParticleSystem = gameObject.GetComponent<ParticleSystem>();
        }

        protected override void Start()
        {
            //Play particle repeating
            base.Start();
            PlayParticle();
        }

        protected void OnDestroy()
        {
            //Do any generic further cleanup
        }

        protected void OnDisable()
        {
            //Stop playing the particle effects
            StopParticle();
        }
    }
}