using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotete : MonoBehaviour
{
    //Deðiþkenler
    [SerializeField] float speedX;
    [SerializeField] float speedY;
    [SerializeField] float speedZ;

    void Update()
    {
        //Coinlerin x,y ve z eksenlerinde 360 derece dönmesine yarayan kod
        transform.Rotate(360 * speedX * Time.deltaTime, 360 * speedY * Time.deltaTime,360 * speedZ * Time.deltaTime);
    }
}
