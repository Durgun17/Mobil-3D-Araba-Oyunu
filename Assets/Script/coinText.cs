using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinText : MonoBehaviour
{
    Text text;
    public static int coinAmount;
    // Start is called before the first frame update
    void Start()
    {
        //Text nesnesine ulaþýr
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //"coinAmount" deðiþkenini "text" nesnesine yazdýrýr
        text.text = coinAmount.ToString();
    }
}
