using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.FPS.Gameplay;
using UnityEngine;

public class handleRegion : MonoBehaviour
{

    public TextMeshProUGUI text;
    public TextMeshProUGUI PAMMOtext;
    public TextMeshProUGUI SAMMOtext;
    public AudioSource AudioSource;
    public AudioClip outsidesfx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        setPAMMO();
        setSAMMO();
    }

    public void goInside()
    {
        text.text = "Inside the region";
        AudioSource.PlayOneShot(outsidesfx);
    }
    public void goOutside()
    {
        text.text = "Outside the region";
        AudioSource.PlayOneShot(outsidesfx);
    }
    public void setPAMMO()
    {
        //if(!GetComponent<PlayerWeaponsManager>())
            PAMMOtext.text = "Primary Ammo: " + GetComponent<PlayerWeaponsManager>().PrimaryAmmo + " / 150";
    }
    public void setSAMMO()
    {
        if (PlayerCharacterController.character == 0)
        {
            SAMMOtext.text = "Secondary Ammo: " + GetComponent<PlayerWeaponsManager>().SecondaryAmmo + " / 10";
        }
        else
        {
            SAMMOtext.text = "Secondary Ammo: " + GetComponent<PlayerWeaponsManager>().SecondaryAmmo + " / 5";
        }
    }
}
