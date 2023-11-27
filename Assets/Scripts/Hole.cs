using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Ball b = other.gameObject.GetComponent<Ball>();

        if (b != null)
        {
            GameManager.instance.PlayerScore += b.Point;
            Destroy(b.gameObject);
        }
    }
}
