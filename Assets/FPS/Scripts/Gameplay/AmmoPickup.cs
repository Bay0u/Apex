using Unity.FPS.Game;
using UnityEngine;

namespace Unity.FPS.Gameplay
{
    public class AmmoPickup : Pickup
    {
        [Tooltip("Number of bullets the player gets")]
        public int BulletCount = 50;

        protected override void OnPicked(PlayerCharacterController byPlayer)
        {
            PlayerWeaponsManager playerWeaponsManager = byPlayer.GetComponent<PlayerWeaponsManager>();

            if (playerWeaponsManager)
            {
                WeaponController weapon1 = playerWeaponsManager.m_WeaponSlots[0];
                WeaponController weapon2 = playerWeaponsManager.m_WeaponSlots[1];
                if (this.gameObject.name == "PrimaryAmmo")
                {
                    if (weapon1.WeaponName == "Sniper" || weapon1.WeaponName == "Shotgun" || weapon1.WeaponName == "Blaster")
                    {
                        if (weapon1 != null && Input.GetButton(GameConstants.k_ButtonPickup))
                        {
                            weapon1.AddCarriablePhysicalBullets(BulletCount);

                            AmmoPickupEvent evt = Events.AmmoPickupEvent;
                            evt.Weapon = weapon1;
                            EventManager.Broadcast(evt);
                            PlayPickupFeedback();
                            Debug.Log(weapon1.GetCurrentAmmo());
                            Destroy(gameObject);
                        }
                    }
                    if (weapon2.WeaponName == "Sniper" || weapon2.WeaponName == "Shotgun" || weapon2.WeaponName == "Blaster")
                    {
                        if (weapon2 != null && Input.GetButton(GameConstants.k_ButtonPickup))
                        {
                            weapon2.AddCarriablePhysicalBullets(BulletCount);

                            AmmoPickupEvent evt = Events.AmmoPickupEvent;
                            evt.Weapon = weapon2;
                            EventManager.Broadcast(evt);
                            PlayPickupFeedback();
                            Debug.Log(weapon2.GetCurrentAmmo());
                            Destroy(gameObject);
                        }
                    }
                }
                if (this.gameObject.name == "SecondaryAmmo")
                {
                    if (weapon1.WeaponName == "GLauncher" || weapon1.WeaponName == "FLauncher")
                    {
                        if (weapon1 != null && Input.GetButton(GameConstants.k_ButtonPickup))
                        {
                            weapon1.AddCarriablePhysicalBullets(BulletCount);

                            AmmoPickupEvent evt = Events.AmmoPickupEvent;
                            evt.Weapon = weapon1;
                            EventManager.Broadcast(evt);
                            PlayPickupFeedback();
                            Debug.Log(weapon1.GetCurrentAmmo());
                            Destroy(gameObject);
                        }
                    }
                    if (weapon2.WeaponName == "GLauncher" || weapon2.WeaponName == "FLauncher")
                    {
                        if (weapon2 != null && Input.GetButton(GameConstants.k_ButtonPickup))
                        {
                            weapon2.AddCarriablePhysicalBullets(BulletCount);

                            AmmoPickupEvent evt = Events.AmmoPickupEvent;
                            evt.Weapon = weapon2;
                            EventManager.Broadcast(evt);
                            PlayPickupFeedback();
                            Debug.Log(weapon2.GetCurrentAmmo());
                            Destroy(gameObject);
                        }
                    }
                }


            }
        }
    }
}
