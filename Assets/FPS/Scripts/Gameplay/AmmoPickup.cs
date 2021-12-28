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

            if (playerWeaponsManager && playerWeaponsManager.m_WeaponSlots.Length!=0)
            {
                if (this.gameObject.name == "PrimaryAmmo")
                {
                    if (playerWeaponsManager.m_WeaponSlots[0] != null) {
                        WeaponController weapon1 = playerWeaponsManager.m_WeaponSlots[0];
                        if (weapon1.WeaponName == "Sniper" || weapon1.WeaponName == "Shotgun" || weapon1.WeaponName == "Blaster")
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

                    if (playerWeaponsManager.m_WeaponSlots[1] != null) {
                        WeaponController weapon2 = playerWeaponsManager.m_WeaponSlots[1];

                        if (weapon2.WeaponName == "Sniper" || weapon2.WeaponName == "Shotgun" || weapon2.WeaponName == "Blaster")
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
                    if (playerWeaponsManager.m_WeaponSlots[0] != null)
                    {
                        WeaponController weapon1 = playerWeaponsManager.m_WeaponSlots[0];

                        if (weapon1.WeaponName == "GLauncher" || weapon1.WeaponName == "FLauncher")
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
                    if (playerWeaponsManager.m_WeaponSlots[1] != null){
                        WeaponController weapon2 = playerWeaponsManager.m_WeaponSlots[1];
                        if (weapon2.WeaponName == "GLauncher" || weapon2.WeaponName == "FLauncher")
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
