using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBorder : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Player _player;

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.rigidbody && collision.rigidbody.GetComponent<Player>())
        {
            _player.transform.position = _spawnPoint.transform.position;
        }
    }

}
