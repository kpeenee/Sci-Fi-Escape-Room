using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] bool hasLockerKey = false;

    public void setHasLockerKey(bool key)
    {
        hasLockerKey = key;
    }

    public bool getHasLockerKey()
    {
        return hasLockerKey;
    }
}
