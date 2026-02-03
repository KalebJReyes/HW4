using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _jumpHeight;
    private bool _isActive;
    public int _points;

    public delegate void Intpoints(int points);
    public event Intpoints PointsChanged;

    public delegate void playerAction();
    public event playerAction jumpAudio;
    public event playerAction UIupdate;
    // Start is called before the first frame update
    void Start()
    {
        _isActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && _isActive) 
        {
            _rb.velocity = new Vector2(_rb.velocity.x, _jumpHeight);
            jumpAudio?.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Points")) 
        {
            _points++;
            PointsChanged?.Invoke(_points);
        } else if (collision.tag.Equals("Pipe")) 
        { 
            _isActive = false;
            UIupdate?.Invoke();
            Destroy(collision.gameObject);
        }
    }
}
