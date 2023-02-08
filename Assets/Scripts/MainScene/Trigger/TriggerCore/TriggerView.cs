using UnityEngine;

namespace MainScene.Trigger.TriggerCore
{
    public abstract class TriggerView : MonoBehaviour
    {

        protected IController Controller
        {
            get
            {
                if (controller == null)
                {
                    controller = CreateController();
                    OnControllerCreate(controller);
                }

                return controller;
            }
        }
        private IController controller;
        public virtual void OnTriggerEnter(Collider other)
        {
            Controller.TriggerEnter();
        }
        protected abstract IController CreateController();
        protected virtual void OnControllerCreate(IController controller)
        {
        }

    }
}
