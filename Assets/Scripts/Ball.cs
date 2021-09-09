using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class Ball : MonoBehaviour
{
    [SerializeField] protected float size;
    [SerializeField] protected float mass;

    protected Rigidbody BallRigidbody;


    protected void Awake()
    {
        BallRigidbody = GetComponent<Rigidbody>();
    }
    
    // Start is called before the first frame update
    private void Start()
    {
        Resize();
        SetMass();
    }
    
    //INHERITANCE
    protected virtual void Resize()
    {
        gameObject.transform.localScale = new Vector3(size, size, size);
    }

    protected virtual void SetMass()
    {
        BallRigidbody.mass = mass;
    }
}
