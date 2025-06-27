using LearnGame.Enemy.States;
using UnityEngine;

namespace LearnGame.Enemy
{
    public class EnemyAIController : MonoBehaviour
    {
        private EnemyStateMachine _stateMachine;
        private EnemyTarget _target;

        [SerializeField]
        private float _viewRadius = 2f;

        protected void Awake()
        {

            var player = FindObjectOfType<PlayerCharachter>();
            var enemyDirectionController = GetComponent<EnemyDirectionController>();

            var navMesher = new NavMesher(transform);
            _target = new EnemyTarget(transform, _viewRadius, player);

            _stateMachine = new EnemyStateMachine(enemyDirectionController, navMesher, _target);
        }

        protected void Update()
        {
            _target.FindClosest();
            _stateMachine.Update();
        }
    }
}