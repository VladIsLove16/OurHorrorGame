using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueBar : MonoBehaviour
{
    [SerializeField] private Transform linebar;
    public void SetValue(float value)
    {
        linebar.localScale = new Vector2(Mathf.Clamp(value, 0, 1f), 1f);
    }
    public void SetValue2(float value)
    {
        linebar.localScale = new Vector2(Mathf.Clamp(value*2, 0, 1f), 1f);
    }
}
