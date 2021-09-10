using System.Collections;
using Contracts;
using UnityEngine;

namespace Concrete
{
    public class FireBall : EffectBall
    {
        protected override void Start()
        {
            base.Start();
            StartCoroutine(SimulateHit());
        }

        private IEnumerator SimulateHit()
        {
            yield return new WaitForSeconds(3.0f);
            StopParticle();
        }
    }
}