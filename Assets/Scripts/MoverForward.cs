using UnityEngine;

public class MovierForward : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _distance;

    private Vector3 _startPosition;

    private int _direction = 1;

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * _direction * _speed * Time.deltaTime);

        if (Vector3.Distance(_startPosition, transform.position) >= _distance)
        {
            _direction *= -1;
            _startPosition = transform.position;
        }
    }
}
