using UnityEngine;

namespace LearnGame.Movement
{
    [RequireComponent(typeof(CharacterController))]
    public class CharahterMovementController : MonoBehaviour
    {

        private static readonly float SqrEpsilon = Mathf.Epsilon * Mathf.Epsilon;

        [SerializeField]
        private float _speed = 1f;
        [SerializeField]
        private float _maxRadiansDelta = 10f;
        [SerializeField]
        private float _acceleration = 2f;

        public Vector3 MovementDirection { get; set; }
        public Vector3 LookDirection { get; set; }
        
        private CharacterController _characterController;

        protected void Awake()
        {
            _characterController = GetComponent<CharacterController>();
        }

        protected void Update()
        {
            Translate();

            if (_maxRadiansDelta > 0 && LookDirection != Vector3.zero) { Rotate(); }
        }

        private void Translate()
        {
            var delta = MovementDirection * _speed * Time.deltaTime;
            _characterController.Move(delta);


        }

        private void Rotate()
        {
            var _currentLookDirection = transform.rotation * Vector3.forward;
            float sqrMagnitude = (_currentLookDirection - LookDirection).sqrMagnitude;

            if (sqrMagnitude > SqrEpsilon )
            {
                var NewRotate = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(LookDirection, Vector3.up), _maxRadiansDelta*Time.deltaTime);
                transform.rotation = NewRotate;
            }
        }

        public void Player_Acceleration()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _speed *= _acceleration;
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                _speed /= _acceleration;
            }
        }
    }
}