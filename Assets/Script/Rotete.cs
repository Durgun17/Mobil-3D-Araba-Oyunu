using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotete : MonoBehaviour
{
    //De�i�kenler
    [SerializeField] float speedX;
    [SerializeField] float speedY;
    [SerializeField] float speedZ;

    void Update()
    {
        //Coinlerin x,y ve z eksenlerinde 360 derece d�nmesine yarayan kod
        transform.Rotate(360 * speedX * Time.deltaTime, 360 * speedY * Time.deltaTime,360 * speedZ * Time.deltaTime);
    }
}
