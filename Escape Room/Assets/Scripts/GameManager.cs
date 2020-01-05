using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] bool hasLockerKey = false;
    [SerializeField] bool hasCode = false;

    public void setHasLockerKey(bool key)
    {
        hasLockerKey = key;
    }

    public bool getHasLockerKey()
    {
        return hasLockerKey;
    }

    public void setHasCode(bool code)
    {
        hasCode = code;
    }

    public bool GetHasCode()
    {
        return hasCode;
    }
}
