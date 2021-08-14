using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KH
{
    public class PlayerAttacker : MonoBehaviour
    {
        public string lastAttack;

        private AnimatorHandler animatorHandler;
        private InputHandler inputHandler;

        private void Awake()
        {
            animatorHandler = GetComponentInChildren<AnimatorHandler>();
            inputHandler = GetComponent<InputHandler>();
        }

        public void HandleWeaponCombo(WeaponItem weapon)
        {
            if (inputHandler.comboFlag)
            {
                animatorHandler.anim.SetBool("canDoCombo", false);

                if (lastAttack == weapon.TH_Light_Attack_1)
                {
                    animatorHandler.PlayTargetAnimation(weapon.TH_Light_Attack_2, true);
                    lastAttack = weapon.TH_Light_Attack_2;
                }
                else if(lastAttack == weapon.TH_Light_Attack_2)
                {
                    animatorHandler.PlayTargetAnimation(weapon.TH_Light_Attack_3, true);
                    lastAttack = weapon.TH_Light_Attack_3;
                }
            }
        }

        public void HandleLightAttack(WeaponItem weapon)
        {
            animatorHandler.PlayTargetAnimation(weapon.TH_Light_Attack_1, true);
            lastAttack = weapon.TH_Light_Attack_1;
        }

        public void HandleHeavyAttack(WeaponItem weapon)
        {
            animatorHandler.PlayTargetAnimation(weapon.TH_Heavy_Attack_1, true);
            lastAttack = weapon.TH_Heavy_Attack_1;
        }
    }
}
