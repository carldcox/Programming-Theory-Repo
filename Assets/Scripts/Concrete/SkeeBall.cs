using Contracts;
using UnityEngine;

namespace Concrete
{
    public class SkeeBall : SportBall
    {
        protected override void Throw(Vector3 throwForce)
        {
            base.Throw(transform.position);
            Debug.Log($"{nameof(SkeeBall)} thrown with {throwForce.ToString()} force!");
        }

        protected override void Catch()
        {
            base.Catch();
            Debug.Log($"{nameof(SkeeBall)} caught!");
        }
        
        private new void Start()
        {
            base.Start();
            Throw(transform.position);
        }
    }
}