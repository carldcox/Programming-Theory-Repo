using UnityEngine;

namespace Contracts
{
    [RequireComponent(typeof(Rigidbody))]
    public abstract class Ball : MonoBehaviour
    {
        [SerializeField] protected float size;
        [SerializeField] protected float mass;

        public Rigidbody BallRigidbody
        {
            get;
            private set;
        }


        protected void Awake()
        {
            BallRigidbody = GetComponent<Rigidbody>();
        }
    
        //Doing some initialization stuff before beginning updates
        protected virtual void Start()
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
}
