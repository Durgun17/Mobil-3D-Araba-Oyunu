using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    //Oyuna sahnesine ge�i� yapan fonksiyon
    public void OyunaBasla()
    {
        SceneManager.LoadScene(1);
    }
    //Oyunadan ��kmam�za yarayan fonksiyon

    public void OyunuKapat()
    {
        Application.Quit();
    }

    //Anamen� sahnesine ge�i� yapan fonksiyon

    public void anaMenuDon()
    {
        SceneManager.LoadScene(0);
    }

    //Hakk�mda sahnesine ge�i� yapan fonksiyon

    public void HakkimdaAc()
    {
        SceneManager.LoadScene(2);
    }
}

