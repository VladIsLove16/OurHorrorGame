using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private ValueSystem _healthSystem=new ValueSystem();
    [SerializeField] private ValueSystem _shieldSystem=new ValueSystem();
    [SerializeField] private EXPSystem _EXPSystem=new EXPSystem();
    private void Start()
    {
        _healthSystem.Setup(100);
        _shieldSystem.Setup(70);
        Invoke(nameof(GetHit),2f);
    }
    public void GetHit(int value)
    {
        _healthSystem.RemoveValue(value);
    }
    public void GetHit()
    {
        _healthSystem.RemoveValue(10);
    }
    public void Heal()
    {
        _healthSystem.AddValue(10);
    }

}
