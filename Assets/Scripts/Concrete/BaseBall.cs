using Contracts;
using UnityEngine;

namespace Concrete
{
    public class BaseBall : SportBall
    {
        protected override void Throw(Vector3 throwForce)
        {
            base.Throw(throwForce);
            Debug.Log($"{nameof(BaseBall)} thrown with {throwForce.ToString()} force!");
        }

        protected override void Catch()
        {
            base.Catch();
            Debug.Log($"{nameof(BaseBall)} caught!");
        }

        private new void Start()
        {
            base.Start();
            Throw(transform.position);
        }
    }
}