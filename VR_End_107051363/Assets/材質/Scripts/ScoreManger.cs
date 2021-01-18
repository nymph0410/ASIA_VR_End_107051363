using UnityEngine;
using UnityEngine.UI;

public class ScoreManger : MonoBehaviour
{
    [Header("分數介面")]
    public Text testScore;
    [Header("分數")]
    public Text score;

    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
    }
}
