using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KH
{
    public class IdleState : State
    {
        public PursueTargetState pursueTargetState;

        public LayerMask detectionLayer;

        public override State Tick(EnemyManager enemyManager, EnemyStats enemyStats, EnemyAnimatorManager enemyAnimatorManager)
        {
            #region �G���ڕW�����m����

            Collider[] colliders = Physics.OverlapSphere(transform.position, enemyManager.detectionRadius, detectionLayer);

            for (int i = 0; i < colliders.Length; i++)
            {
                CharacterStats characterStats = colliders[i].transform.GetComponent<CharacterStats>();

                if (characterStats != null)
                {
                    Vector3 targetDirection = characterStats.transform.position - enemyManager.transform.position;
                    float viewableAngle = Vector3.Angle(targetDirection, enemyManager.transform.forward);

                    if (viewableAngle > enemyManager.minimumDetectionAngle && viewableAngle < enemyManager.maximumDetectionAngle)
                    {
                        enemyManager.currentTarget = characterStats;
                    }
                }
            }

            #endregion

            #region ���̏�Ԃɐ؂�ւ���

            if (enemyManager.currentTarget != null)
            {
                return pursueTargetState;
            }
            else
            {
                return this;
            }

            #endregion
        }
    }
}