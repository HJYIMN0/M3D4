using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb: MonoBehaviour
{
    public int damage = 20;
    public void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.CompareTag("Player"))
        {
            LifeController playerHp = player.GetComponent<LifeController>();
            playerHp.TakeDamage(damage);
            Destroy(gameObject);            
        }
    }
    
}