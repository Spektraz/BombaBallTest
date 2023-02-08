namespace MainScene.Trigger.TriggerCore
{
    public abstract class TriggerController<T> : IController where T : TriggerView
    {
        protected T View { get; }

        public TriggerController(T view)
        {
            this.View = view;
        }
        public abstract void TriggerEnter();
    }
    public interface IController
    {
        void TriggerEnter();
    }
}
