using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using UnityEngine.UIElements;

public class MovementTest
{
    private GameObject _player;
    private Movement _movement;

    [OneTimeSetUp]
    public void Setup()
    {

    }

    [
        UnityTest,
        Description(
            "Assert that the entity is moving"
        )
    ]

    public IEnumerator Movement_MoveRight_Success()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
        yield return null;

        //Given
        _player = GameObject.Find("Player");
        Assert.That(_player, Is.Not.Null);

        _movement = _player.GetComponent<Movement>();
        Assert.That(_movement, Is.Not.Null);

        var initialPosition = _movement.rb.transform.position;

        // Act
        yield return new WaitForSeconds(5);

        var newPosition = _movement.rb.transform.position;
        Assert.That(newPosition.x, Is.GreaterThan(initialPosition.x));

        // Assert
    }
}
