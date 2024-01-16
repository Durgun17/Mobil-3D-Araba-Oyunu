using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Araba : MonoBehaviour
{
    public WheelCollider sag_on_tekerlek, sol_on_tekerlek, sag_arka_tekerlek, sol_arka_tekerlek;

    public float motorhýzý, dönmehýzý;
    public Joystick tus;


    void Update()
    {
        //Joystick ile kontrol etmemize yardýmcý olan kodlar
        sag_arka_tekerlek.motorTorque = motorhýzý * tus.Vertical;
        sol_arka_tekerlek.motorTorque = motorhýzý * tus.Vertical;
         sag_on_tekerlek.steerAngle = dönmehýzý * tus.Horizontal;
         sol_on_tekerlek.steerAngle = dönmehýzý * tus.Horizontal;
    }


    //"Bitis" etiketine temas ettiðimizde oyun bitiþ ekranýna yönlendiren kod
    void OnTriggerEnter(Collider other)
    {
        // Eðer araba bitiþ çizgisini geçtiyse
        if (other.CompareTag("Bitis"))
        {
            SceneManager.LoadScene(3);
        }
    }
}
