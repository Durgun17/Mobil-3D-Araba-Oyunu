using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NewBehaviourScript : MonoBehaviour
{
    //Deðiþkenler
    int coins = 0;
    [SerializeField] Text coinsText;
    private void OnTriggerEnter(Collider other)
    {
        //"coin" etiketinde olan nesnelere temas ettiðimizde yok eden ve bakiyemize ekleyen kod
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            coinsText.text = "Coins: " + coins;
        }
    }
}
