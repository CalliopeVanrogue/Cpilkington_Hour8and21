using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int healthpoints = 3992;
    
    void Start()
    {
        healthpoints = usePotion(healthpoints);
        Debug.Log(healthpoints);
        healthpoints = usePotion(healthpoints);
        Debug.Log(healthpoints);
        healthpoints = usePotion(healthpoints);
        Debug.Log(healthpoints);
        healthpoints = usePotion(healthpoints);
        Debug.Log(healthpoints);
        healthpoints = usePotion(healthpoints);
        Debug.Log(healthpoints);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int usePotion(int health)
    {
    health += 400;
    return health;
    }
}
