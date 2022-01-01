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
    }
    public void goOutside()
    {
        text.text = "Outside the region";
    }
    public void setPAMMO()
    {
        PAMMOtext.text = "Primary Ammo: " + GetComponent<PlayerWeaponsManager>().PrimaryAmmo + " / 150";
    }
    public void setSAMMO()
    {
        SAMMOtext.text = "Secondary Ammo: "+ GetComponent<PlayerWeaponsManager>().SecondaryAmmo+ " / 5";
    }
}
