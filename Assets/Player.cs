using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody;
    bool isJumping;
    public float JumpForce = 100f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump");
            isJumping = true;
        }
    }

    private void FixedUpdate()
    {
        if (isJumping)
        {
            rigidbody.AddForce(new Vector2(0f, 100f));
            isJumping = false;
        }
    }
}
