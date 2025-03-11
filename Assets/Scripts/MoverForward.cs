using UnityEngine;

public class MoverForward : MonoBehaviour
{
    [SerializeField] private float _speed;

    /*private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
    }
*/
    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}
