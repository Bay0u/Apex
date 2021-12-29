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
                //Debug.Log(playerWeaponsManager.m_WeaponSlots.Length);
                if (playerWeaponsManager.m_WeaponSlots[0] != null || playerWeaponsManager.m_WeaponSlots[1] != null)
                {
                    //string weapontag = WeaponPrefab.gameObject.tag;
                    if (playerWeaponsManager.m_WeaponSlots[0] != null)
                    { 
                        if (WeaponPrefab.gameObject.tag == playerWeaponsManager.m_WeaponSlots[0].gameObject.tag)
                        {
                        //Debug.Log("ana me4 fady");

                        WeaponController oldWeapon = playerWeaponsManager.m_WeaponSlots[0];
                        foreach (GameObject Pickupweapon in pickupweapons)
                        {
                            GameObject weapon = Pickupweapon.transform.GetChild(0).gameObject;

                            string oldWeaponName = oldWeapon.gameObject.name.Substring(0, oldWeapon.gameObject.name.Length - 7);

                            if (weapon.name == oldWeaponName)
                            {
                                    Vector3 weaponPos = this.gameObject.transform.position;
                                    int bullets = oldWeapon.m_CarriedPhysicalBullets;
                                    WeaponPrefab.AddCarriablePhysicalBullets(bullets);
                                    Destroy(gameObject);
                                    playerWeaponsManager.AddWeapon(WeaponPrefab);
                                    playerWeaponsManager.RemoveWeapon(oldWeapon);
                                    Instantiate(Pickupweapon, weaponPos, Quaternion.identity);
                                    PlayPickupFeedback();
                                    return;
                            }

                        }



                        }
                    }

                    if (playerWeaponsManager.m_WeaponSlots[1] != null)
                    {
                        //Debug.Log("ana me4 fady");
                        WeaponController oldWeapon = playerWeaponsManager.m_WeaponSlots[1];

                        
                        //playerWeaponsManager.SwitchWeapon(true);
                        //Debug.Log(oldWeapon.name);
                        if (WeaponPrefab.gameObject.tag == oldWeapon.gameObject.tag)
                        {
                            foreach (GameObject Pickupweapon in pickupweapons)
                            {
                                GameObject weapon = Pickupweapon.transform.GetChild(0).gameObject;
                                string oldWeaponName = oldWeapon.gameObject.name.Substring(0, oldWeapon.gameObject.name.Length - 7);
                                if (weapon.name == oldWeaponName)
                                {
                                    //Debug.Log("d5alt gwa 2");
                                    Vector3 weaponPos = this.gameObject.transform.position;
                                    int bullets = oldWeapon.m_CarriedPhysicalBullets;
                                    WeaponPrefab.AddCarriablePhysicalBullets(bullets);
                                    Destroy(gameObject);
                                    playerWeaponsManager.AddWeapon(WeaponPrefab);
                                    playerWeaponsManager.RemoveWeapon(oldWeapon);                                   
                                    Instantiate(Pickupweapon, weaponPos, Quaternion.identity);
                                    PlayPickupFeedback();

                                    return;
                                }
                            }                            
                        }
                    }

                    if (playerWeaponsManager.m_WeaponSlots[2] != null)
                    {
                        //Debug.Log("ana me4 fady");
                        WeaponController oldWeapon = playerWeaponsManager.m_WeaponSlots[2];
                        //playerWeaponsManager.SwitchWeapon(true);
                        //Debug.Log(oldWeapon.name);
                        if (WeaponPrefab.gameObject.tag == oldWeapon.gameObject.tag)
                        {
                            foreach (GameObject Pickupweapon in pickupweapons)
                            {
                                GameObject weapon = Pickupweapon.transform.GetChild(0).gameObject;
                                string oldWeaponName = oldWeapon.gameObject.name.Substring(0, oldWeapon.gameObject.name.Length - 7);
                                if (weapon.name == oldWeaponName)
                                {
                                    //Debug.Log("d5alt gwa 2");
                                    Vector3 weaponPos = this.gameObject.transform.position;
                                    int bullets = oldWeapon.m_CarriedPhysicalBullets;
                                    WeaponPrefab.AddCarriablePhysicalBullets(bullets);
                                    Destroy(gameObject);
                                    playerWeaponsManager.AddWeapon(WeaponPrefab);
                                    playerWeaponsManager.RemoveWeapon(oldWeapon);
                                    Instantiate(Pickupweapon, weaponPos, Quaternion.identity);
                                    PlayPickupFeedback();

                                    return;
                                }
                            }
                        }
                    }
                    else
                    {
                        //adding the weapon
                        //Debug.Log("ana m4 fady bs fe mkan");
                        playerWeaponsManager.AddWeapon(WeaponPrefab);
                        // Handle auto-switching to weapon if no weapons currently
                        playerWeaponsManager.SwitchWeapon(true);
                        Destroy(gameObject);
                    }
                    }
                    else
                    {
                    //Debug.Log("ana fady");
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