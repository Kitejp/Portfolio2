using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KH
{
    public class EnemyStats : CharacterStats
    {
        [Header("敵を倒したときに得られるスコア")] public int score;

        Animator animator;
        InputHandler inputHandler;
        CameraHandler cameraHandler;

        private void Awake()
        {
            animator = GetComponentInChildren<Animator>();
            inputHandler = FindObjectOfType<InputHandler>();
            cameraHandler = FindObjectOfType<CameraHandler>();
        }

        void Start()
        {
            maxHealth = SetMaxHealthFromHealthLevel();
            currentHealth = maxHealth;
        }

        private int SetMaxHealthFromHealthLevel()
        {
            maxHealth = healthLevel * 10;
            return maxHealth;
        }

        public void TakeDamage(int damage)
        {
            currentHealth = currentHealth - damage;

            animator.Play("Damage");

            if (currentHealth <= 0)
            {
                currentHealth = 0;
                animator.Play("Death");
                inputHandler.lockOnFlag = false;
                cameraHandler.ClearLockOnTargets();
                Destroy(this.gameObject, 1f);
                GameManager.instance.score += this.score;
            }
        }
    }
}
