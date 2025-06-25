using UnityEngine;

namespace LearnGame.Shooting
public class Bullet : MonoBehaviour
{

    private Vector3 _direction;
    private float _flySpeed;
    private float _maxflyDistance;
    private float _currentFly;

    public void Initialize(Vector3 direction, float maxFlyDistance, float flySpeed)
    {
        _direction = direction;
        _maxflyDistance = maxFlyDistance;
        _flySpeed = flySpeed;
    }


    void Update()
    {
        var delta = _flySpeed * Time.deltaTime;
        _currentFly += delta;
        transform.Translate(_direction * delta);

        if (_currentFly >= _maxflyDistance) {
            Destroy(gameObject);
        }
    }
}
