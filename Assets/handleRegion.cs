using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class handleRegion : MonoBehaviour
{

    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goInside()
    {
        text.text = "Inside the region";
    }
    public void goOutside()
    {
        text.text = "Outside the region";
    }
}
