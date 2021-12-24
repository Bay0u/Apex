using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class range : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        print("Hello!");
        if (col.gameObject.CompareTag("Enemy"))
        {
            Unity.FPS.Gameplay.PlayerCharacterController.ObjectsInRange.Add(col.gameObject);
            print("Added");
        }
    }
    private void OnTriggerExit(Collider col)
    {
        print("Bye!");
        if (col.gameObject.CompareTag("Enemy"))
        {
            Unity.FPS.Gameplay.PlayerCharacterController.ObjectsInRange.Remove(col.gameObject);
            print("Removed");
        }
    }
}
