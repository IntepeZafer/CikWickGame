using JetBrains.Annotations;
using UnityEngine;

public class TestingScript : MonoBehaviour
{
    public int myInt = 5;

    void Awake() // TODO:Oyun Başlamadan Önce Çalışır
    {
        Debug.Log("Awake Çalıştı");
        Debug.Log("myInt Değeri: " + myInt);
    }

    
    void Start() // TODO:  Oyun Başladıktan Sonra Çalışır
    {
        Debug.Log("Awake Çalıştı"); 
        Debug.Log("myInt Değeri: " + myInt); 
    }

    void Update() // TODO: Her Frame'de Bir Kez Çalışır
    {

    }
    
    private void FixedUpdate() // TODO: Fizik İşlemleri İçin Kullanılır
    {

    }
    void LateUpdate() // TODO: Update'den Sonra Çalışır
    {
        
    }
}