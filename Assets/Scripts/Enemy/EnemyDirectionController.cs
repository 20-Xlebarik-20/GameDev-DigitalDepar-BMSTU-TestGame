using LearnGame.Movement;
using System.Collections;
using UnityEngine;

namespace LearnGame.Enemy
{
    public class EnemyDirectionController : MonoBehaviour, IMovementDirectionSource
    {

        public Vector3 MovementDirection { get; private set; }

        public void UpdateMovementDirection(Vector3 targetPosition)
        {
            var realdirection = targetPosition - transform.position;
            MovementDirection = new Vector3(realdirection.x, 0, realdirection.z).normalized;
        }
    }
}