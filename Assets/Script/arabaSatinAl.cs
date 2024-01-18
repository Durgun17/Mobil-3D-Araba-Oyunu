using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class arabaSatinAl : MonoBehaviour
{
    //De�i�kenler
    public static int para;
    public GameObject[] arabalar;
    public GameObject panel;
    public GameObject durdur;
    int buySari = 0;
    int buyMavi = 0;
    int buySiyah = 0;
    int buyMor = 0;
    public Text sari_araba_yazisi, mavi_araba_yazisi, mor_araba_yazisi, siyah_araba_yazisi;
    public Text ParaDurumu;
    Text text;
    public static int coinAmount;
    public Text ParaDurumu2;
    public Transform spawn;




    // Start is called before the first frame update
    void Start()
    {
        //"Text" nesnesine eri�en kod
        text = GetComponent<Text>();

    }

    void Update()
    {
        //Test i�in paray� artt�rma kodu
        if (Input.GetKeyUp(KeyCode.T))
        {
            coinAmount = 5000;
        }


        //Test i�in marketi a�ma kodu
        if (Input.GetKeyUp(KeyCode.B)) 
        {
            panel.SetActive(true);
        }
        // Markette ve oyunda paray� g�steren kod
        if (coinAmount  == 0)
        {
            ParaDurumu.text = ("Hi� paran�z kalmad� :( ");
            ParaDurumu2.text = ("Hi� paran�z kalmad� :( ");
        }
        else
        {
            ParaDurumu.text = ("Paran�z = " + coinAmount);
            ParaDurumu2.text = ("Paran�z = " + coinAmount);
        }


        // Test i�in Oyunu Durdurma Kodu
        if (Input.GetKeyUp(KeyCode.P))
        {
            durdur.SetActive(true);

        }

    }

    //-----------------------------MARKET KODLARI--------------------------------

    // �lk arabay� �cretsiz alma kodu
    public void standartaraba()
    {
        for (int i = 0; i < arabalar.Length; i++)
        {
            arabalar[i].SetActive(false);
            arabalar[0].SetActive(true);
            panel.SetActive(false);
            arabalar[0].transform.position = spawn.transform.position;

        }
    }

    // Araba sat�n ald�ktan sonra bakiye azalmatmas� yapan kod
    public void SariAraba()
    {
        if (coinAmount >= 200)
        {
            if (buySari == 0)
            {
                buySari = 10;
                para -= 200;
                coinAmount -= 200;

            }

            // Arabay� ald�ktan sonra "Sat�n al" yaz�s�n� "SE�" yaz�s� ile de�i�tirme kodu
            for (int i = 0; i < arabalar.Length; i++)
            {
                arabalar[i].SetActive(false);
                arabalar[1].SetActive(true);
                panel.SetActive(false);
                arabalar[1].transform.position = spawn.transform.position;
                sari_araba_yazisi.text = ("SE�");
            }
        }
        // Arabay� daha �nce sat�n ald�ysak tekrar bakiyeden d��memesi i�in kontrol kodu
        if (buySari >= 10)
        {
            for (int i = 0; i < arabalar.Length; i++)
            {
                arabalar[i].SetActive(false);
                arabalar[1].SetActive(true);
                panel.SetActive(false);
            }
        }

    }
    public void SiyahAraba()
    {
        // Araba sat�n ald�ktan sonra bakiye azalmatmas� yapan kod

        if (coinAmount >= 300)
        {
            if (buySiyah == 0)
            {
                buySiyah = 10;
                para -= 300;
                coinAmount -= 300;
            }
            // Arabay� ald�ktan sonra "Sat�n al" yaz�s�n� "SE�" yaz�s� ile de�i�tirme kodu
            for (int i = 0; i < arabalar.Length; i++)
            {
                arabalar[i].SetActive(false);
                arabalar[2].SetActive(true);
                panel.SetActive(false);
                arabalar[2].transform.position = spawn.transform.position;
                siyah_araba_yazisi.text = ("SE�");
            }
        }
        // Arabay� daha �nce sat�n ald�ysak tekrar bakiyeden d��memesi i�in kontrol kodu
        if (buySiyah >= 10)
        {
            for (int i = 0; i < arabalar.Length; i++)
            {
                arabalar[i].SetActive(false);
                arabalar[2].SetActive(true);
                panel.SetActive(false);
            }
        }

    }

    public void MaviAraba()
    {
        // Araba sat�n ald�ktan sonra bakiye azalmatmas� yapan kod

        if (coinAmount >= 400)
        {
            
            if (buyMavi == 0)
            {
                 buyMavi = 10;
                para -= 400;
                coinAmount -= 400;

            }

            // Arabay� ald�ktan sonra "Sat�n al" yaz�s�n� "SE�" yaz�s� ile de�i�tirme kodu
            for (int i = 0; i < arabalar.Length; i++)
            {
                arabalar[i].SetActive(false);
                arabalar[3].SetActive(true);
                panel.SetActive(false);
                arabalar[3].transform.position = spawn.transform.position;
                mavi_araba_yazisi.text = ("SE�");
            }
        }
        // Arabay� daha �nce sat�n ald�ysak tekrar bakiyeden d��memesi i�in kontrol kodu
        if (buyMavi >= 10)
        {
            for (int i = 0; i < arabalar.Length; i++)
            {
                arabalar[i].SetActive(false);
                arabalar[3].SetActive(true);
                panel.SetActive(false);
            }
        }

    }

    public void MorAraba()
    {
        // Araba sat�n ald�ktan sonra bakiye azalmatmas� yapan kod

        if (coinAmount >= 500)
        {
            if (buyMor == 0)
            {
                buyMor = 10;
                para -= 500;
                coinAmount -= 500;

            }
            // Arabay� ald�ktan sonra "Sat�n al" yaz�s�n� "SE�" yaz�s� ile de�i�tirme kodu
            for (int i = 0; i < arabalar.Length; i++)
            {
                arabalar[i].SetActive(false);
                arabalar[4].SetActive(true);
                panel.SetActive(false);
                arabalar[4].transform.position = spawn.transform.position;
                mor_araba_yazisi.text = ("SE�");
            }
        }
        // Arabay� daha �nce sat�n ald�ysak tekrar bakiyeden d��memesi i�in kontrol kodu
        if (buyMor >= 10)
        {
            for (int i = 0; i < arabalar.Length; i++)
            {
                arabalar[i].SetActive(false);
                arabalar[4].SetActive(true);
                panel.SetActive(false);
            }
        }

    }

    //Men�y� a�mam�za yaran fonksiyon
    public void MenuAc()
    {
        panel.SetActive(true);

    }

    //Men�y� kapatmam�za yaran fonksiyon
    public void MenuKapat()
    {
        panel.SetActive(false);

    }

    //Oyunu Durdurmam�za yaran fonksiyon
    public void DurdurAc()
    {
        durdur.SetActive(true);
    }

    //Oyuna Devam etmemize yaran fonksiyon
    public void DurdurKapat()
    {
        durdur.SetActive(false);
    }

    //Anamen�ye d�nmemize yaran fonksiyon
    public void anaMenuDon()
    {
        SceneManager.LoadScene(0);
    }
    //Oyunu yeniden ba�latmam�za yaran fonksiyon
    public void yenidenBaslat()
    {
        SceneManager.LoadScene(1);
    }


    
}
