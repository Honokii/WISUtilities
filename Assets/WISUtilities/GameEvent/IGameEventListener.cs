namespace WISUtilities.GameEvent {
    public interface IGameEventListener<T>
    {
        void OnEventRaised(T item);
    }
}