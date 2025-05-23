using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int coins;
    public void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.CompareTag("Player"))
        {
            coins++;
            Debug.Log($"Sono state raccolte un totale di {coins} monete!");
            Destroy(gameObject);
        }
    }

}
