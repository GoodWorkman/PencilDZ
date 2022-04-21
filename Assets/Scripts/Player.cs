using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   //[SerializeField] private float _speed = 2f;
   private Rigidbody2D _rigidbody2D;

   private void Start()
   {
      _rigidbody2D = GetComponent<Rigidbody2D>();
   }

   public void FixedMove(float h, float v)
   {
      Vector2 direction = (Vector2.right * h + Vector2.up * v); // когда был normalized, продолжалось движение по инерции
      _rigidbody2D.velocity = direction;
      //_rigidbody2D.velocity = new Vector2(h, v).normalized * _speed;
   }
}
