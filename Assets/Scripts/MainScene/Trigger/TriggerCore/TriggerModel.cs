using UnityEngine;

namespace MainScene.Trigger.TriggerCore
{
    public abstract class TriggerModel : MonoBehaviour
    {
        [Header("Collider ball")] 
        [SerializeField] private Collider m_collider;
        public Collider Сollider => m_collider;
    }
}
