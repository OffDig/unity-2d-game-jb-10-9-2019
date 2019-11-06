using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Collectable
{
    // Start is called before the first frame update
    public override void HandleCollected()
    {
        base.HandleCollected();
        CollectableManger.Instance.HandleCoinCollected();
    }
}
