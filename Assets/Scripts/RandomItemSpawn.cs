using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItemSpawn : MonoBehaviour
{
    public GameObject FoodItem, MilkItem, GoldItem, IronItem, HelmetItem, TorsoItem, SwordItem, ShieldItem;

    int WhatToSpawn;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            WhatToSpawn = Random.Range(1, 7);

            switch (WhatToSpawn)
            {
                case 1:
                    Instantiate(FoodItem, transform.position, Quaternion.identity);
                    break;

                case 2:
                    Instantiate(MilkItem, transform.position, Quaternion.identity);
                    break;

                case 3:
                    Instantiate(GoldItem, transform.position, Quaternion.identity);
                    break;

                case 4:
                    Instantiate(IronItem, transform.position, Quaternion.identity);
                    break;

                case 5:
                    Instantiate(HelmetItem, transform.position, Quaternion.identity);
                    break;

                case 6:
                    Instantiate(TorsoItem, transform.position, Quaternion.identity);
                    break;

                case 7:
                    Instantiate(SwordItem, transform.position, Quaternion.identity);
                    break;

                case 8:
                    Instantiate(ShieldItem, transform.position, Quaternion.identity);
                    break;

            }
        }
    }
}
