
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    internal float speed { get { return _speed; } set { _speed = value; } }
    private Rigidbody2D _rb;
    private const float sqrt2 = 1.41421356237f;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector3 direct = new Vector3(horizontal * Time.deltaTime * speed, vertical * Time.deltaTime * speed);
        if (((int)horizontal & (int)vertical) != 0)
            direct = new Vector3(direct.x / sqrt2, direct.y / sqrt2);
        Move(direct);
    }

    void Move(Vector3 direct)
    {
        _rb.velocity = direct;
    }
}
