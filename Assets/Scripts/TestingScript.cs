using System.Collections.Generic;

using UnityEngine;

namespace SlientWalker
{
    public class TestingScript : MonoBehaviour
{
    public int number = 5;
        [SerializeField]private int[] numbersArray;
        [SerializeField]private List<int> numberLsit = new List<int>();
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
    public void myFunction()
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

        switch (number)
        {
            case 1:
                Debug.Log("Sayı 1");
                break;
            case 2:
                Debug.Log("Sayı 2");
                break;
            case 3:
                Debug.Log("Sayı 3");
                break;
            case 4:
                Debug.Log("Sayı 4");
                break;
            case 5:
                Debug.Log("Sayı 5");
                break;
            default:
                Debug.Log("Sayı 1-5 Arasında Değil");
                break;
        }
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("For Döngüsü: " + i);
        }

        while (number < 10)
        {
            Debug.Log("While Döngüsü: " + number);
            number++;
        }
        do
        {
            Debug.Log("Do-While Döngüsü: " + number);
            number++;
        } while (number < 10);

        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int num in numbers)
        {
            Debug.Log("Foreach Döngüsü: " + num);
        }
        List<int> numberList = new List<int> { 1, 2, 3, 4, 5 };
        foreach (int num in numberList)
        {
            Debug.Log("Liste Elemanı: " + num);
        }
        numberList.Add(6); // Listeye 6 eklenir
        numberList.Remove(3); // Listeden 3 çıkarılır
        numberList.Insert(2, 10); // 2. indekse 10 eklenir
        Debug.Log("Liste Boyutu: " + numberList.Count); // Çıktı
    }
}
}

