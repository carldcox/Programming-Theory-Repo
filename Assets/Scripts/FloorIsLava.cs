using UnityEngine;

public class FloorIsLava : MonoBehaviour
{
        private void OnCollisionEnter(Collision other)
        {
                if (other.gameObject.CompareTag("Ball"))
                {
                        Destroy(other.gameObject);
                }
        }
}