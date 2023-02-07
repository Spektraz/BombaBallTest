namespace System
{
    public class EventHolder 
    {
        public Action<string> OnFinishGameEvent;
        public void OnFinishGame(string state)
        {
            var temp = OnFinishGameEvent;
            temp?.Invoke(state);
        }
        public Action<bool> OnShootBombEvent;
        public void OnShootBomb(bool state)
        {
            var temp = OnShootBombEvent;
            temp?.Invoke(state);
        }
        public Action<float> OnSizeBombEvent;
        public void OnSizeBomb(float state)
        {
            var temp = OnSizeBombEvent;
            temp?.Invoke(state);
        }
        public Action<bool> OnBoomEvent;
        public void OnBoom(bool state)
        {
            var temp = OnBoomEvent;
            temp?.Invoke(state);
        }
        public Action OnDeleteTreeEvent;
        public void OnDeleteTree()
        {
            var temp = OnDeleteTreeEvent;
            temp?.Invoke();
        }
    }
}
