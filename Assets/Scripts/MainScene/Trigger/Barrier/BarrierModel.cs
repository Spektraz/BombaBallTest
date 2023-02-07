using MainScene.Trigger.TriggerCore;
using UnityEngine;

namespace MainScene.Trigger.Barrier
{
    public class BarrierModel : TriggerModel
    {
        [Header("Collider bomb")] 
        [SerializeField] private Collider m_colliderBomb;
        public Collider ColliderBomb => m_colliderBomb;
    }
}
