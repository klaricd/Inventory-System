using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEffect : MonoBehaviour
{
    // using food/milk (destroy object + effect)

    public GameObject Effect;
    private Transform _player;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Use()
    {
        Instantiate(Effect, _player.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
