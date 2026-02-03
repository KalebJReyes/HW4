using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField] AudioSource _pointsAudio;
    [SerializeField] AudioSource _jumpAudio;

    private void Start()
    {
        GameController.Instance.player.PointsChanged += playPoint;
        GameController.Instance.player.jumpAudio += playJump;
    }

    private void playJump()
    {
        _jumpAudio.Play();
    }

    private void playPoint(int pnts)
    {
        _pointsAudio.Play();
    }
}
