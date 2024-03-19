using UnityEngine;
using UnityEngine.UI;

public class Addiction : MonoBehaviour
{
    public int correctAnswer;

    public void AddNumbers(int n, int m)
    {
        correctAnswer = n + m;
    }
}
