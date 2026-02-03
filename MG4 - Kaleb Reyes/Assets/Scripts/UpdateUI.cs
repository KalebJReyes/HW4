using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _pointsText;
    [SerializeField] private GameObject _gameoverText;

    private void Start()
    {
        GameController.Instance.player.PointsChanged += UpdatePoints;
        GameController.Instance.player.UIupdate += UpdateGameover;
    }

    private void UpdatePoints(int points) { 
        _pointsText.text = points.ToString();
    }

    private void UpdateGameover() { 
        _gameoverText.SetActive(true);
    }
}
