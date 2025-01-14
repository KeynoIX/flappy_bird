using UnityEngine;

public class Floor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnColisionEnter2D(Collision2D collision)
    {
        Player _player = collision.gameObject.GetComponent<Player>();
        if (_player != null)
        {
            _player.gameObject.SetActive(false);
    }
    }
}   