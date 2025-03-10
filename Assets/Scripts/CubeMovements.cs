using System;
using UnityEngine;

public class CubeMovements : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private float _moveDistance;
    [SerializeField] private float _scaleAmount;

    private Vector3 _startPosition;
    private Vector3 _startScale;

    private float _time;

    void Start()
    {
        _startPosition = transform.position;
        _startScale = transform.localScale;
    }

    void Update()
    {
        float maxMoveDistance = _moveDistance * 2;
        _time += Time.deltaTime;

        float moveOffset = Mathf.PingPong(_time * _moveSpeed, maxMoveDistance) - _moveDistance;
        transform.position = _startPosition + transform.forward * moveOffset;

        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);

        float scaleOffset = Mathf.PingPong(_time * _scaleSpeed, _scaleAmount);
        transform.localScale = _startScale + Vector3.one * scaleOffset;
    }
}
