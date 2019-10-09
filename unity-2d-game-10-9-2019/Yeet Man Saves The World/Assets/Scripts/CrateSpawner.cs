using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateSpawner : MonoBehaviour
{
    public GameObject createPrefab;

    public int amountOfCratesToSpawn;
    //Jarrett is a poopy stinky. That's what his mom told me at least. *Jarrett spews all his problems*, Me - "Who are you?"
    public void Start()
    {
        for (int i = 0; i < amountOfCratesToSpawn; i++)
        {
            Instantiate(createPrefab, transform.localPosition, Quaternion.identity, this.transform);
        }
    }
}
