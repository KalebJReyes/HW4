using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] Transform _transform;
    // Update is called once per frame
    void Update()
    {
        _transform.Translate(Vector3.left * Time.deltaTime * _speed);

        if (_transform.position.x < -15) {
            Destroy(gameObject);
        }
    }
}
