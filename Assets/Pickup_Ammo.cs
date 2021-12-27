using System.Collections;
using System.Collections.Generic;
using Unity.FPS.Game;
using UnityEngine;

namespace Unity.FPS.Gameplay
{
    public class Pickup_Ammo : Pickup
    {
        public float AmmoAmount;

        protected override void OnPicked(PlayerCharacterController player)
        {
            //WeaponController playerHealth = player.GetComponent<Health>();
            /*if (playerHealth && playerHealth.CanPickupHealth() && Input.GetButton(GameConstants.k_ButtonPickup))
            {
                playerHealth.Heal(HealAmount);
                PlayPickupFeedback();
                Destroy(gameObject);
            }*/
        }
    }
}