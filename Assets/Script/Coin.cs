using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        //"Araba" Etiketli nesneler "Coin" Etiketli nesnelere De�eince oyun paras� 20 $ art�yor
        if (other.tag == "araba")
        {
            arabaSatinAl.coinAmount += 20;
            arabaSatinAl.para += 20;
            Destroy(gameObject);
        }
    }
}
