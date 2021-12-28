using System.Collections.Generic;
using Unity.FPS.Game;
using UnityEngine;
namespace Unity.FPS.Gameplay
{
    public class WeaponPickup : Pickup
    {
        [Tooltip("The prefab for the weapon that will be added to the player on pickup")]
        public WeaponController WeaponPrefab;
        public List<GameObject> pickupweapons = new List<GameObject>();

        protected override void Start()
        {
            base.Start();

            // Set all children layers to default (to prefent seeing weapons through meshes)
            foreach (Transform t in GetComponentsInChildren<Transform>())
            {
                if (t != transform)
                    t.gameObject.layer = 0;
            }

        }

        protected override void OnPicked(PlayerCharacterController byPlayer)
        {
            PlayerWeaponsManager playerWeaponsManager = byPlayer.GetComponent<PlayerWeaponsManager>();
            if (playerWeaponsManager)
            {
                Debug.Log(playerWeaponsManager.m_WeaponSlots.Length);
                if (playerWeaponsManager.m_WeaponSlots[0] != null)
                {
                    Debug.Log("ana me4 fady");
                    string weapontag = WeaponPrefab.gameObject.tag;
                    if (weapontag == playerWeaponsManager.m_WeaponSlots[0].gameObject.tag)
                    {
                        WeaponController oldWeapon = playerWeaponsManager.m_WeaponSlots[0];
                        foreach (GameObject Pickupweapon in pickupweapons)
                        {
                            GameObject weapon = Pickupweapon.transform.GetChild(0).gameObject;
                            if(weapon == oldWeapon.gameObject)
                            {
                                Debug.Log("d5alt");
                                Instantiate(Pickupweapon, this.gameObject.transform.position , Quaternion.identity);
                            }
                            
                        }
                        playerWeaponsManager.AddWeapon(WeaponPrefab);
                        //this.WeaponPrefab = oldWeapon;
                        playerWeaponsManager.RemoveWeapon(oldWeapon);
                        playerWeaponsManager.SwitchWeapon(true);

                        return;
                    }

                    if (playerWeaponsManager.m_WeaponSlots[1] != null)
                    {
                        if (weapontag == playerWeaponsManager.m_WeaponSlots[1].gameObject.tag)
                        {
                            WeaponController oldWeapon = playerWeaponsManager.m_WeaponSlots[1];
                            foreach (GameObject Pickupweapon in pickupweapons)
                            {
                                GameObject weapon = Pickupweapon.transform.GetChild(0).gameObject;
                                if (weapon == oldWeapon.gameObject)
                                {
                                    Debug.Log("d5alt");
                                    Instantiate(Pickupweapon, this.gameObject.transform.position, Quaternion.identity);
                                }

                            }
                            playerWeaponsManager.AddWeapon(WeaponPrefab);
                            //this.WeaponPrefab = oldWeapon;
                            playerWeaponsManager.RemoveWeapon(oldWeapon);
                            playerWeaponsManager.SwitchWeapon(true);

                            //Debug.Log(oldWeapon.name);
                            return;
                        }
                    }
                    else{ 
                        //adding the weapon
                        playerWeaponsManager.AddWeapon(WeaponPrefab);
                        // Handle auto-switching to weapon if no weapons currently
                        playerWeaponsManager.SwitchWeapon(true);
                        Destroy(gameObject);
                    }
                    }
                    else
                    {
                    Debug.Log("ana fady");
                    //adding the weapon
                    playerWeaponsManager.AddWeapon(WeaponPrefab);
                    // Handle auto-switching to weapon if no weapons currently
                    playerWeaponsManager.SwitchWeapon(true);
                    Destroy(gameObject);
                    }

                    PlayPickupFeedback();
                    
                
            }
        }
    }
}