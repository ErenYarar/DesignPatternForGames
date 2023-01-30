using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ben bunu yaptım diye haber verecek (Bağırma işlemi, haberi yayacak olan nesne)
public abstract class Subject : MonoBehaviour
{
    private List<Observer> _observers = null; //Gözlemcilerin listesi

    [SerializeField] private SubjectType _subjectType;

    public SubjectType SubjectType => _subjectType; 

    public void RegisterObserver(Observer observer) // Gözlemciler kayıt edilmeli
    {
        if(_observers == null) //Listemiz boşsa listemizi doldur
            _observers = new List<Observer>();
        
        _observers.Add(observer); //Gözlemci atandı
    }

    private void Start()
    {
        //Observer içine kayıt et
        ObserverManager.Instance.RegisterSubject(this); 
    }

    //Butona basıldığını bildirim verecek
    public void Notify(NotificationType notificationType)
    {
        foreach (var observer in _observers)
        {
            // Üye olan bütün observer'lar içine git
            observer.OnNotify(notificationType);
        }
    }
}