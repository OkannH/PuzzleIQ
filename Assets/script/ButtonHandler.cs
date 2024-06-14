using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public Text numberText; // NumberText'i bağlamak için bir referans

    // Metni güncelleyen yardımcı fonksiyon
    private void AddNumber(string newNumber)
    {
        // Mevcut metni al
        string currentText = numberText.text;

        // Eğer mevcut metin sadece "0" ise, yeni değeri doğrudan ekle
        if (currentText == "0")
        {
            currentText = newNumber;
        }
        else
        {
            // Mevcut metne basılan butonun değerini ekle
            currentText += newNumber;
        }

        // NumberText'e güncellenmiş metni yazdır
        numberText.text = currentText;
    }

    // Buton 0'a basıldığında
    public void Button0Clicked()
    {
        // Sayıyı ekle
        AddNumber("0");
    }

    // Buton 1'e basıldığında
    public void Button1Clicked()
    {
        // Sayıyı ekle
        AddNumber("1");
    }

    // Buton 2'ye basıldığında
    public void Button2Clicked()
    {
        // Sayıyı ekle
        AddNumber("2");
    }

    // Diğer butonlar için aynı şekilde devam eder...
    public void Button3Clicked()
    {
        // Sayıyı ekle
        AddNumber("3");
    }

    public void Button4Clicked()
    {
        // Sayıyı ekle
        AddNumber("4");
    }

    public void Button5Clicked()
    {
        // Sayıyı ekle
        AddNumber("5");
    }

    public void Button6Clicked()
    {
        // Sayıyı ekle
        AddNumber("6");
    }

    public void Button7Clicked()
    {
        // Sayıyı ekle
        AddNumber("7");
    }

    public void Button8Clicked()
    {
        // Sayıyı ekle
        AddNumber("8");
    }

    public void Button9Clicked()
    {
        // Sayıyı ekle
        AddNumber("9");
    }
    public void ButtonDeleteClicked()
    {
        // NumberText'in metnini temizle
        numberText.text = "";
    }
    // ButtonOK'a basıldığında
    public void ButtonOKClicked()
    {
        // Mevcut metni al
        string currentText = numberText.text;

        // Eğer metin "9" ise
        if (currentText == "9")
        {

            // Forward adlı sahneye geç
            SceneManager.LoadScene("forward"); // "Forward" yerine kendi sahne adınızı kullanın
        }
        else
        {
            // "Wrong Answer." mesajını ekrana yaz
            numberText.text = "Wrong Answer.";

            // Yanlış cevap durumunda, NumberText'in metnini temizle
            numberText.text = "";
        }
    }

    public void nextClicked()
    {
        // Forward adlı sahneye geç
        SceneManager.LoadScene("level2"); // "Forward" yerine kendi sahne adınızı kullanın
    }
    public void startClicked()
    {
        // Forward adlı sahneye geç
        SceneManager.LoadScene("level1"); // "Forward" yerine kendi sahne adınızı kullanın
    }

    public void ButtonOKClicked2()
    {
        // Mevcut metni al
        string currentText = numberText.text;

        // Eğer metin "9" ise
        if (currentText == "96")
        {

            // Forward adlı sahneye geç
            SceneManager.LoadScene("forward"); // "Forward" yerine kendi sahne adınızı kullanın
        }
        else
        {
            // "Wrong Answer." mesajını ekrana yaz
            numberText.text = "Wrong Answer.";

            // Yanlış cevap durumunda, NumberText'in metnini temizle
            numberText.text = "";
        }
    }
}


