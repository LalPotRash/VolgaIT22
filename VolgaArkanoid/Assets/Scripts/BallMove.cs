using UnityEngine;

public class BallMove : MonoBehaviour
{
    [SerializeField] private float _force = 300f;
    [SerializeField] private float _offsetX = 100f;
    private Rigidbody2D _rigidBody2D;
    private bool _isActive;

    void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetAxis("Jump") > 0 && !_isActive)
        {
            KickBall();
        }
    }

    void KickBall()
    {
        _isActive = true;
        transform.SetParent(null);
        _rigidBody2D.AddForce(new Vector2(_offsetX, _force));
    }
}
