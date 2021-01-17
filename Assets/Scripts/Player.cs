﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
    [SerializeField]
    private int maxHealth = 100;

    [SyncVar]
    private int currentHealth;

    void Awake()
    {
        SetDefaults();
    }

    public void TakeDamage(int _amout)
    {
        currentHealth -= _amout;

        Debug.Log(transform.name + " now has " + currentHealth + " health");
    }

    public void SetDefaults()
    {
        currentHealth = maxHealth;
    }
}
