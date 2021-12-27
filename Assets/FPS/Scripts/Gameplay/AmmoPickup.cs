using Unity.FPS.Game;
using UnityEngine;

namespace Unity.FPS.Gameplay
{
    public class AmmoPickup : Pickup
    {
        [Tooltip("Weapon those bullets are for")]
        public WeaponController Weapon;

        [Tooltip("Number of bullets the player gets")]
        public int BulletCount = 30;

        protected override void OnPicked(PlayerCharacterController byPlayer)
        {
            PlayerWeaponsManager playerWeaponsManager = byPlayer.GetComponent<PlayerWeaponsManager>();
            if (playerWeaponsManager)
            {
                Debug.Log("");
                WeaponController weapon = playerWeaponsManager.HasWeapon(Weapon);
                if (weapon != null && Input.GetButton(GameConstants.k_ButtonPickup))
                {
                    Debug.Log("d5lt hena");
                    weapon.AddCarriablePhysicalBullets(BulletCount);

                    AmmoPickupEvent evt = Events.AmmoPickupEvent;
                    evt.Weapon = weapon;
                    EventManager.Broadcast(evt);
                    PlayPickupFeedback();
                    Debug.Log(weapon.GetCurrentAmmo());
                    Destroy(gameObject);
                }
            }
        }
    }
}
