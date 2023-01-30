using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSystem : Observer
{
    private void Start()
    {
        //MovementPanel'inde bir şey olursa bu paneli dinle
        ObserverManager.Instance.RegisterObserver(this, SubjectType.MovementPanel);
    }


    // Butonlara tıklanınca hareket ettir
    public override void OnNotify(NotificationType notificationType)
    {
        switch (notificationType)
        {
            case NotificationType.ForwardBtn:
                transform.Translate(Vector3.forward);
                break;
            case NotificationType.BackBtn:
                transform.Translate(Vector3.back);
                break;
            case NotificationType.LeftBtn:
                transform.Translate(Vector3.left);
                break;
            case NotificationType.RightBtn:
                transform.Translate(Vector3.right);
                break;
        }
    }
}