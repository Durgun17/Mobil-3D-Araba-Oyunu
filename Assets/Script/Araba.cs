using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Araba : MonoBehaviour
{
    public WheelCollider sag_on_tekerlek, sol_on_tekerlek, sag_arka_tekerlek, sol_arka_tekerlek;

    public float motorh�z�, d�nmeh�z�;
    public Joystick tus;


    void Update()
    {
        //Joystick ile kontrol etmemize yard�mc� olan kodlar
        sag_arka_tekerlek.motorTorque = motorh�z� * tus.Vertical;
        sol_arka_tekerlek.motorTorque = motorh�z� * tus.Vertical;
         sag_on_tekerlek.steerAngle = d�nmeh�z� * tus.Horizontal;
         sol_on_tekerlek.steerAngle = d�nmeh�z� * tus.Horizontal;
    }


    //"Bitis" etiketine temas etti�imizde oyun biti� ekran�na y�nlendiren kod
    void OnTriggerEnter(Collider other)
    {
        // E�er araba biti� �izgisini ge�tiyse
        if (other.CompareTag("Bitis"))
        {
            SceneManager.LoadScene(3);
        }
    }
}
