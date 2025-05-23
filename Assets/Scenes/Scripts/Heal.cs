using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public int healAmount = 20;
    public void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.CompareTag("Player"))
        {
            LifeController playerHp = player.GetComponent<LifeController>();
            playerHp.TakeHeal(healAmount);
            Destroy(gameObject);            
        }
    }
}
