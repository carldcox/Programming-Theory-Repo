using UnityEngine;
using Random = UnityEngine.Random;

namespace Contracts
{
        public abstract class SportBall : Ball
        {
                [SerializeField] protected Vector3 RotationAxis;
                
                protected bool Thrown = false;

                protected virtual void Throw(Vector3 throwForce)
                {
                        Thrown = true;
                        RotationAxis = new Vector3(Random.value, Random.value, Random.value);
                }

                protected virtual void Catch()
                {
                        Thrown = false;
                }

                protected void Update()
                {
                        if (!Thrown)
                                return;
                        
                        transform.Rotate(RotationAxis);
                }
        }
}