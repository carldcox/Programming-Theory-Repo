using UnityEngine;

public abstract class SportBall : Ball
{
        protected abstract void Throw(Vector3 throwForce);

        protected abstract void Catch();

        protected abstract void Kick(Vector3 kickForce);
        protected abstract void Kick(Vector3 kickForce, Vector3 direction);
}