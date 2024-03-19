using System;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine;

public class AddictionTest
{
    private GameObject _mathObj;
    private Addiction _addiction;

    [OneTimeSetUp]
    public void Setup()
    {
            _mathObj = new GameObject("MathObject");

            _addiction = _mathObj.AddComponent<Addiction>();
    }

    [
        Test,
        Description(
            "Assert that the addiction is correct"
        )
    ]
    [TestCase(10,5)]
    [TestCase(1,3)]
    [TestCase(22,-3)]
    public void Addiction_AddNumbers_Success(int n, int m)
    {
        //Given
        Assert.That(_addiction, Is.Not.Null);

        // Act
        _addiction.AddNumbers(n, m);

        // Assert
        Assert.That(_addiction.correctAnswer, Is.EqualTo(n+m));
    }
}
