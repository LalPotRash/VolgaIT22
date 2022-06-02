using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    private float _horizontalAxisInput;

    void Update()
    {
        _horizontalAxisInput = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -33.5f, 33.5f), transform.position.y, 0);
        transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + _horizontalAxisInput, transform.position.y, 0), Time.deltaTime * _speed);
    }
}
