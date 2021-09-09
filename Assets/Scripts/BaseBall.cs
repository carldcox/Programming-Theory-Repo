using UnityEngine;

public class BaseBall : Ball
{
    protected override void Throw()
    {
        size = 5.0f;
        base.Throw();
    }
}