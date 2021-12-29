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
                    if (playerWeaponsManager.m_WeaponSlots[0] != null)
                    {
                        WeaponController weapon1 = playerWeaponsManager.m_WeaponSlots[0];
                        if (weapon1.WeaponName == "Sniper" || weapon1.WeaponName == "Shotgun" || weapon1.WeaponName == "Assault")
                        {
                            weapon1.AddCarriablePhysicalBullets(BulletCount);

                            AmmoPickupEvent evt = Events.AmmoPickupEvent;
                            evt.Weapon = weapon1;
                            EventManager.Broadcast(evt);
                            PlayPickupFeedback();
                            //Debug.Log(weapon1.GetCurrentAmmo());
                            Destroy(gameObject);
                        }
                    }


                    if (playerWeaponsManager.m_WeaponSlots[1] != null)
                    {
                        WeaponController weapon2 = playerWeaponsManager.m_WeaponSlots[1];

                        if (weapon2.WeaponName == "Sniper" || weapon2.WeaponName == "Shotgun" || weapon2.WeaponName == "Assault")
                        {
                            weapon2.AddCarriablePhysicalBullets(BulletCount);

                            AmmoPickupEvent evt = Events.AmmoPickupEvent;
                            evt.Weapon = weapon2;
                            EventManager.Broadcast(evt);
                            PlayPickupFeedback();
                            //Debug.Log(weapon2.GetCurrentAmmo());
                            Destroy(gameObject);
                        }


                    }

                    if (playerWeaponsManager.m_WeaponSlots[2] != null)
                    {
                        WeaponController weapon3 = playerWeaponsManager.m_WeaponSlots[2];

                        if (weapon3.WeaponName == "Sniper" || weapon3.WeaponName == "Shotgun" || weapon3.WeaponName == "Assault")
                        {
                            weapon3.AddCarriablePhysicalBullets(BulletCount);

                            AmmoPickupEvent evt = Events.AmmoPickupEvent;
                            evt.Weapon = weapon3;
                            EventManager.Broadcast(evt);
                            PlayPickupFeedback();
                            Debug.Log(weapon3.GetCurrentAmmo());
                            Destroy(gameObject);
                        }
                    }
                    else
                    { 
                        playerWeaponsManager.addPrimary(BulletCount);
                        Destroy(gameObject);
                    }
                }
                if (this.gameObject.name == "SecondaryAmmo")
                {
                    if (playerWeaponsManager.m_WeaponSlots[0] != null)
                    {
                        WeaponController weapon1 = playerWeaponsManager.m_WeaponSlots[0];

                        if (weapon1.WeaponName == "GLauncher" || weapon1.WeaponName == "FGLauncher")
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
                        if (weapon2.WeaponName == "GLauncher" || weapon2.WeaponName == "FGLauncher")
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
                    if (playerWeaponsManager.m_WeaponSlots[2] != null)
                    {
                        WeaponController weapon3 = playerWeaponsManager.m_WeaponSlots[2];

                        if (weapon3.WeaponName == "GLauncher" || weapon3.WeaponName == "FGLauncher")
                        {
                            weapon3.AddCarriablePhysicalBullets(BulletCount);

                            AmmoPickupEvent evt = Events.AmmoPickupEvent;
                            evt.Weapon = weapon3;
                            EventManager.Broadcast(evt);
                            PlayPickupFeedback();
                            Debug.Log(weapon3.GetCurrentAmmo());
                            Destroy(gameObject);
                        }
                    }
                    else
                    {
                        playerWeaponsManager.addSecondary(BulletCount);
                        Destroy(gameObject);
                    }
                }


            }
        }
    }
}
