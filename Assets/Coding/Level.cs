using UnityEngine;

public class Level : MonoBehaviour
{
    public float speed = -10f;
    public float deadzone = -20f;
    Vector3 initPosition;

    void Start()
    {
        initPosition = transform.position;
    }

    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0f);

        if (transform.position.x < deadzone)
        {
            transform.position = initPosition;
        }
    }
}
