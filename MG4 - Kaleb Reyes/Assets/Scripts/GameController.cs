using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] Transform _spawnTransform;
    [SerializeField] GameObject _pipe;
    [SerializeField] float _spawnInterval;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = _spawnInterval;
        Instantiate(_pipe, _spawnTransform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0) {
            Instantiate(_pipe, _spawnTransform.position, Quaternion.identity);
            timer = _spawnInterval;
        }
    }
}
