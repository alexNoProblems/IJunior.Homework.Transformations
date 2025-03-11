using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private float _maxScaleSize;
    [SerializeField] private float _minScaleSize;

    private Vector3 _originalScaleSize;
    
    private float _scaleDirection = 1f;

    private void Start()
    {
        _originalScaleSize = transform.localScale;
    }

    private void Update()
    {
        float scaleChange = _scaleSpeed * Time.deltaTime * _scaleDirection;
        transform.localScale += new Vector3(scaleChange, scaleChange, scaleChange);

        if (transform.localScale.x >= _maxScaleSize || transform.localScale.x <= _minScaleSize)
            _scaleDirection *= -1;
    }
}
