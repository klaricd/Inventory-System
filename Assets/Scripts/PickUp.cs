using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory _inventory;
    public GameObject ItemButton;

    private void Start()
    {
        _inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < _inventory.Slots.Length; i++)
            {
                if(_inventory.IsFull[i] == false)
                {
                    Debug.Log("Item picked up!");
                    _inventory.IsFull[i] = true;
                    Instantiate(ItemButton, _inventory.Slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
