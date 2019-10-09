using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectableManger : MonoBehaviour
{
    private int _totalCoins;
    private int _collectedCoins;

    public TextMeshProUGUI coinCount;

    public static CollectableManger Instance;

    public void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        _totalCoins = FindObjectsOfType<Collectable>().Length;
        DisplayCoinCount();
    }
    void DisplayCoinCount()
    {
        coinCount.SetText(_collectedCoins + " / " + _totalCoins);
        
    }

    public void HandleCoinCollected()
    {
        _collectedCoins++;
        DisplayCoinCount();
        if (_collectedCoins >= _totalCoins)
        {
            YouWinMenu.Instance.Show();
        }

        SoundManager.Instance.PlayCoinCollectSound();
    }
}
