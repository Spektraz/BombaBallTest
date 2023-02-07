using UnityEngine;

namespace System
{
    public static class GlobalConst
    {
        [Header("Scene")] 
        public const string MainScene = "MainScene";
        public const string StartScene = "StartScene";
        
        [Header("Animator")] 
        public const string OpenDoorAnimator = "OpenDoor";

        [Header("Result Game")] 
        public const string LooseGame = "Loose";
        public const string WinGame = "Win";

        [Header("Speed ball")] 
        public const float SpeedBall = 0.001f;
        public const float JumpBall = 3;
        public const float TimeJump = 1;
        public const float StandardBombSize = 0.1f;
        public const float LifeBall = 0.01f;

        [Header("Bomb")]
        public const float UpBomb = 0.000001f;
        public const float LaunchVelocity = 5;
        public const float TimeLifeBomb = 1;
        public const float ColliderSizeBoom = 2;
        public const float ColliderUsually = 0.5f;
        
        [Header("Tree")] 
        public const float LifeTree = 0.5f;
    }
}
