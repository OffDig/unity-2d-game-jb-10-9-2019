using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!_hasBeenCollected && collision.gameObject.GetComponent<PlatformerCharacter2D>())
        {
           HandleCollected();
        }
    }
    private bool _hasBeenCollected = false;

    // Update is called once per frame
        void HandleCollected()
        {
        _hasBeenCollected = true;
        CollectableManger.Instance.HandleCoinCollected();

        Destroy(gameObject);

        }
    
}
