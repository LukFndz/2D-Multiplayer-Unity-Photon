using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Text scoreText;

    private Player player;

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        scoreText.text = "Score: " + player.playerScore.Value;
    }

    public void UpdateScoreUI(int newValue, int oldValue)
    {
        scoreText.text = "Score: " + newValue;
    }
}