using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshToggler : MonoBehaviour
{
   public GameObject HumanObject;
private bool isAct = true;


public void Vissibility()
{
    if (isAct)
    {
        HumanObject.SetActive(false);
        isAct = false;
    }
    else
    {
        HumanObject.SetActive(true);
        isAct=true;
    }
}

}
