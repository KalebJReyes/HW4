using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] Transform _spawnTransform;
    [SerializeField] GameObject _pipe;
    [SerializeField] float _spawnInterval;

    public static GameController Instance { get; private set; }
    public Player player {  get; private set; }

    private float timer;

    private void Awake()
    {
        if (Instance != null && Instance != this) {
            Destroy(this);
            return;
        }

        Instance = this;

        GameObject playerObj = GameObject.FindWithTag("Player");
        player = playerObj.GetComponent<Player>();
    }
    // Start is called before the first frame update
    void Start()
    {
        timer = _spawnInterval;
        _spawnTransform.transform.localPosition = new Vector2(_spawnTransform.position.x, Random.Range(-9, -2));
        Instantiate(_pipe, _spawnTransform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0) {
            _spawnTransform.transform.localPosition = new Vector2(_spawnTransform.position.x, Random.Range(-9, -2));
            Instantiate(_pipe, _spawnTransform.position, Quaternion.identity);
            timer = _spawnInterval;
        }
    }
}
