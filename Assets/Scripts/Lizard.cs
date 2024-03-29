﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject otherGameObject = other.gameObject;

        if (other.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(otherGameObject);
        }
        
    }

}
