using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    //Oyuna sahnesine geçiþ yapan fonksiyon
    public void OyunaBasla()
    {
        SceneManager.LoadScene(1);
    }
    //Oyunadan çýkmamýza yarayan fonksiyon

    public void OyunuKapat()
    {
        Application.Quit();
    }

    //Anamenü sahnesine geçiþ yapan fonksiyon

    public void anaMenuDon()
    {
        SceneManager.LoadScene(0);
    }

    //Hakkýmda sahnesine geçiþ yapan fonksiyon

    public void HakkimdaAc()
    {
        SceneManager.LoadScene(2);
    }
}

