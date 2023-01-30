using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//"Ben butonlara bastım" diye haber verecek
public class MovementPanel : Subject
{
    public void ForwardOnClick() 
    {
        Notify(NotificationType.ForwardBtn);
    }
    public void BackOnClick()
    {
        Notify(NotificationType.BackBtn);
    }
    public void RightOnClick()
    {
        Notify(NotificationType.RightBtn);
    }
    public void LeftOnClick()
    {
        Notify(NotificationType.LeftBtn);
    }
    
}
public interface IMovementObserver
{
    void OnMovement(string direction);
}

public class MovementSubject
{
    private List<IMovementObserver> observers = new List<IMovementObserver>();

    public void AddObserver(IMovementObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IMovementObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers(string direction)
    {
        foreach (IMovementObserver observer in observers)
        {
            observer.OnMovement(direction);
        }
    }
}



