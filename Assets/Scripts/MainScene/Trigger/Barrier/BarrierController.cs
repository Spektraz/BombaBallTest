using System;
using UnityEngine;

namespace MainScene.Trigger.Barrier
{
    public class BarrierController 
    {
        private BarrierView m_view = null;
        private float m_timer = 0;
        private bool m_isBoom = false;
        public BarrierController(BarrierView barrierView)
        {
            m_view = barrierView;
            m_timer = GlobalConst.LifeTree;
        }
        public void Initialize()
        {
            InitializeEvents();
        }
        private void InitializeEvents()
        {
            ApplicationContainer.Instance.EventHolder.OnDeleteTreeEvent += DeleteTree;
        }
        public void TriggerEnter()
        {
            ApplicationContainer.Instance.EventHolder.OnFinishGame(GlobalConst.LooseGame);
        }
        public void TriggerBomb()
        {
            m_isBoom = true;
            ApplicationContainer.Instance.EventHolder.OnBoom(true);
        }
        public void DeleteTree()
        {
            if(!m_isBoom)
                return;
            m_timer -= Time.deltaTime;
            if (!(m_timer < 0)) return;
            m_isBoom = false;
            m_view.DestroyObject();
        }
        private void DisposeEvents()
        {
            ApplicationContainer.Instance.EventHolder.OnDeleteTreeEvent -= DeleteTree;
        }
        public void Dispose()
        {
            DisposeEvents();
        }
    }
}
