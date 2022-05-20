using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunHit : MonoBehaviour
{
  public int SunValue;
   void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.SendMessage("ApplyDamage", 1);
			Debug.Log(collision.gameObject.tag);
        }
			Debug.Log(collision.gameObject.tag);
    }
  }

