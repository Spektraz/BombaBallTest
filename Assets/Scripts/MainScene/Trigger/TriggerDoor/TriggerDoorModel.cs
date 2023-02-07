using MainScene.Trigger.TriggerCore;
using UnityEngine;

namespace MainScene.Trigger.TriggerDoor
{
    public class TriggerDoorModel : TriggerModel
    {
        [Header("Animator Door")]
        [SerializeField] private Animator m_animatorDoor = null;
        
        public Animator AnimatorDoor => m_animatorDoor;

    }
}