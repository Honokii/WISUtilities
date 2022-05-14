using System;
using UnityEngine.Events;
using WISUtilities.GameEvent;

//Listener
public class OnGameEventListener : BaseGameEventListener<OnGameEventArgs, OnGameEvent, OnGameEventResponse> { }

//Response
[Serializable]
public class OnGameEventResponse : UnityEvent<OnGameEventArgs> { }