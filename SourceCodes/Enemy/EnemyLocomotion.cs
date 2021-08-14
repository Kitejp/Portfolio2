using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KH
{
    public class EnemyLocomotion : MonoBehaviour
    {
        public LayerMask detectionLayer;

        private EnemyManager enemyManager;
        private EnemyAnimatorManager enemyAnimatorManager;

        private void Awake()
        {
            enemyManager = GetComponent<EnemyManager>();
            enemyAnimatorManager = GetComponentInChildren<EnemyAnimatorManager>();
        }
    }
}
