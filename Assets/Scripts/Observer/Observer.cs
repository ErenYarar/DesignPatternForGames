using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Diğerlerini gözlemleyecek ve sadece haberleri dinleyecek
public abstract class Observer : MonoBehaviour
{
    /*
    abstract: alttaki sınıfda içini doldurmak için verildi
    OnNotify: Bir haber, bildirim geldiğinde bu fonk. çalışacak
    Neye göre çalışacak? Bir değişkene ihtiyaç var.
    */ //Gözlemlemek istediğimiz obje:
    public abstract void OnNotify(NotificationType notificationType);
}

