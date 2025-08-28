using JetBrains.Annotations;
using UnityEngine;

public class TestingScript : MonoBehaviour
{
    int number = 5;
    void Awake() // TODO:Oyun Başlamadan Önce Çalışır
    {
        Debug.Log("Awake Çalıştı");
        Debug.Log("Normal Debug Log Mesajı");
        Debug.LogWarning("Uyarı Mesajı");
        Debug.LogError("Hata Mesajı");
    }


    void Start() // TODO:  Oyun Başladıktan Sonra Çalışır
    {
        Debug.Log("Start Çalıştı");
        myFunction();
    }

    void Update() // TODO: Her Frame'de Bir Kez Çalışır
    {
        Debug.Log("Update Çalıştı");
    }

    private void FixedUpdate() // TODO: Fizik İşlemleri İçin Kullanılır
    {
        Debug.Log("FixedUpdate Çalıştı");
    }
    void LateUpdate() // TODO: Update'den Sonra Çalışır
    {
        Debug.Log("LateUpdate Çalıştı");
    }
    void myFunction()
    {
        if (number > 10)
        {
            Debug.Log("Sayı 10'dan Büyük");
        }
        else if (number < 10)
        {
            Debug.Log("Sayı 10'dan Küçük");
        }
        else if (number == 10)
        {
            Debug.Log("Sayı 10'a Eşit");
        }
        else
        {
            Debug.Log("Bilinmeyen Durum");
        }
    }
}