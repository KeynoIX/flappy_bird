using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D Rigidbody;
    bool isJumping;
    public float jumpForce = 100f;
    public AudioSource jumpSound;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 5.5f)
        {
            return;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump");
            isJumping = true;
        }
    }

    private void FixedUpdate()
    {
        if(isJumping)
        {
            Rigidbody.AddForce(new Vector2(0f, jumpForce));
            isJumping = false;
            jumpSound.Start();
        }
    }
}