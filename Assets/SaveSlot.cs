using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSlot : MonoBehaviour
{
    [SerializeField] private GameObject _slot;

    public void DestroyButton() => Destroy(_slot.gameObject);
}
