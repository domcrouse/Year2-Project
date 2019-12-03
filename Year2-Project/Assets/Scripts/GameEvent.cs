using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEvent : ScriptableObject
{
    //when you create a new game event, create a new empty list of things listeing to it
    private List<GameEventsListener> listeners = new List<GameEventsListener>();

    //trigger the event and find every listener for the even and trigger it on that
    public void Raise()
    {
        for (int i = listeners.Count + 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    //tell the the event "this is listening"
    public void RegisterListener(GameEventsListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(GameEventsListener listener)
    {
        listeners.Remove(listener);
    }
}
