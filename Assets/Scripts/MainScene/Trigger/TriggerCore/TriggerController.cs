namespace MainScene.Trigger.TriggerCore
{
    public class TriggerController<T>  where T : TriggerView<TriggerModel>
    {
        public T m_viewModel = default(T);
        public TriggerController(T viewModel)
        {
            m_viewModel = viewModel;
        }

        public virtual void TriggerEnter()
        {
            
        }
    }
}
