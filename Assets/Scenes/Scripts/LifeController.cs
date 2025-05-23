using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    protected int life = 100;

    public void TakeDamage(int dmg)
    { 
        life -= dmg;
        if (life <= 0)
        {
            Debug.Log("Il giocatore è stato sconfitto.");
            Destroy(gameObject);
            life = 0;
        }
        Debug.Log($" Questi sono gli hp attuali dell'eroe: {life}");
    }

    public void TakeHeal(int amount)
    {

        life += amount;
        if (life <= 0)
        {
            Debug.Log("Qualcosa è andato storto...");
            life = 0;
        }
        Debug.Log($" Questi sono gli hp attuali dell'eroe: {life}");
    }
}
