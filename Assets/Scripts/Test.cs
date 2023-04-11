using JuhaKurisu.PopoTools.Deterministics;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
        print(new Fix64(10));
        print((new Fix64(10) / new Fix64(3)));
        print(Fix64.maxValue - new Fix64(10) / new Fix64(3));
        print(Fix64.maxValue);
        print(Fix64.minValue);
    }
}
