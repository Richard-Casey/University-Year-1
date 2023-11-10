using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject[] objectsToSpawn; // Used arrays! Applied knowledge check me out.

    // Start is called before the first frame update
    void Start()
    {
        int index = Random.Range(0, objectsToSpawn.Length); // The index is a result of the object that i dragged into the variable. The idea here was that i would pre-place the
                                                            // point in which the flys would be able to spawn on the level. I would then use unity's randomiser to decide if a red
                                                            // blue or green fly would be spawned on those positions. Then i intended to alter Morgan's score script to reflect the
                                                            // different impact that those would have. The red one would give the user +5 second on the clock the blue would give
                                                            // 20 points and the green would give 10.
        Instantiate(objectsToSpawn[index], transform.position, Quaternion.identity);
    }

  
}
