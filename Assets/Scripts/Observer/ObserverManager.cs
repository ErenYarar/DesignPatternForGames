using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Yönetimi sağlayacak
public class ObserverManager : MonoBehaviour
{
    #region Singleton 

    private static ObserverManager _instance = null;

    public static ObserverManager Instance => _instance;

    #endregion

    private List<Subject> _subjects = null; //Subject tut

    private void Awake()
    {
        _instance = this;
    }

    //Subject Kaydı
    public void RegisterSubject(Subject subject) 
    {
        if (_subjects == null)
            _subjects = new List<Subject>();
        
        _subjects.Add(subject);
    }

    //Observer Kaydı
    public void RegisterObserver(Observer observer, SubjectType subjectType)
    {
        foreach (var subject in _subjects)
        {
            // subjectType ile isteneni bul ve observer'ı kayıt et
            if (subject.SubjectType == subjectType)
            {
                subject.RegisterObserver(observer);
            }
        }
    }
}

public enum NotificationType
{
    ForwardBtn,
    BackBtn,
    LeftBtn,
    RightBtn
}

public enum SubjectType
{
    MovementPanel
}
