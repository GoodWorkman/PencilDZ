using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Player _player;
    private float h;
    private float v;

    private void Start()
    {
        _player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        _player.FixedMove(h, v);
    }
}
