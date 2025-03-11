using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private float _scaleDirection = 1f;

    private void Update()
    {
        float scaleChange = _scaleSpeed * Time.deltaTime * _scaleDirection;
        transform.localScale += new Vector3(scaleChange, scaleChange, scaleChange);
    }
}
