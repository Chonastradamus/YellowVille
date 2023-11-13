
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void Events(params object[] parameters);
    static Dictionary<string, Events> _myEvent = new Dictionary<string, Events>();

    public static void Subscribe(string name, Events events)
    {
        if (_myEvent.ContainsKey(name))
            _myEvent[name] += events;
        else
            _myEvent.Add(name, events);
    }

    public static void Unsubscribe(string name, Events events)
    {
        if (_myEvent.ContainsKey(name))
        {
            _myEvent[name] -= events;

            if (_myEvent[name] == null)
                _myEvent.Remove(name);
        }
    }

    public static void Trigger(string name, params object[] parameters)
    {
        if (_myEvent.ContainsKey(name))
            _myEvent[name](parameters);
    }
}
