using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] protected float size;
    [SerializeField] protected float mass;

    protected Rigidbody BalRigidbody;
    
    
    // Start is called before the first frame update
    private void Start()
    {
        BalRigidbody = GetComponent<Rigidbody>();
        Throw();
    }

    // Update is called once per frame
    private void Update()
    {
        //Make the ball rotate just to see how a mono behaviour works in child classes
        gameObject.transform.Rotate(Vector3.up, 10.0f);
    }

    protected virtual void Throw()
    {
        gameObject.transform.localScale = new Vector3(size, size, size);
    }
}
