using System.Collections;
using System.Collections.Generic;
using Contracts;
using UnityEngine;
using Random = UnityEngine.Random;

namespace DefaultNamespace
{
    public class BallSpawner : MonoBehaviour
    {
        [SerializeField] private List<Ball> balls;
        [SerializeField] private float force = 5;


        private IEnumerator Start()
        {
            yield return new WaitForSeconds(3.0f);
            InvokeRepeating(nameof(LaunchNextBall), 0.0f, 3.0f);
        }

        private void LaunchNextBall()
        {
            //Get a random ball from the list
            var randomIndex = Random.Range(0, balls.Count);

            var ball = Instantiate(balls[randomIndex], transform.position, transform.rotation);
            ball.BallRigidbody.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}