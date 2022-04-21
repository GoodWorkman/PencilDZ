using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SveLoader : MonoBehaviour
{
  public Transform parent;
  public GameObject _buttonFab;

  public void CreateButton() => Instantiate(_buttonFab, parent.transform);


}
