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
                if (this.gameObject.name == "PrimaryAmmo")
                {
                    if (playerWeaponsManager.PrimaryAmmo <= 100) 
                    {
                        playerWeaponsManager.addPrimary(BulletCount);
                        Destroy(gameObject);
                    }
                    
                    
                }
                if (this.gameObject.name == "SecondaryAmmo")
                {
                    if (playerWeaponsManager.SecondaryAmmo <= 8)
                    {

                        if(playerWeaponsManager.SecondaryAmmo <= 3 || PlayerCharacterController.character==0){

                        playerWeaponsManager.addSecondary(BulletCount);
                        Destroy(gameObject);}
                    }
                    
                }


            }
        }
    }
}
