using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventsListener : MonoBehaviour
{
    //marking the event we are listening to
    public GameEvent Event;
    //provides a dropdown to show the response
    public UnityEvent Response;

    //regestring an event listener when the object is enabled and the opposite for when we are disabling the object
    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    //when the event is raised/triggered for a response
    public void OnEventRaised()
    {
        
    }
}
