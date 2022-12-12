// using UnityEngine;
// using UnityEngine.UI;

// public class GameManager : MonoBehaviour
// {
//     public Ball ball;
//     private int _plyerScore;
//     private int _computerScore;
//     public Paddle playerPaddle;
//     public Paddle computerPaddle;
//     public Text playerScoreText;
//     public Text computerScoreText;

//     public void PlayerScores()
//     {
//         _plyerScore++;
//         Debug.Log(_plyerScore);
//         this.playerScoreText.text = _plyerScore.ToString();
//         ResetRound();
//     }
//     public void ComputerScores()
//     {
//         _computerScore++;
//         this.computerScoreText.text = _computerScore.ToString();
//         ResetRound();
//     }

//     private void ResetRound()
//     {
//         this.ball.ResetPosition();
//         this.playerPaddle.ResetPosition();
//         this.computerPaddle.ResetPosition();
//         this.ball.AddStartingForce();
//     }
// }

using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Paddle playerPaddle;
    public int playerScore { get; private set; }
    public Text playerScoreText;

    public Paddle computerPaddle;
    public int computerScore { get; private set; }
    public Text computerScoreText;

    private void Start()
    {
        NewGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            NewGame();
        }
    }

    public void NewGame()
    {
        SetPlayerScore(0);
        SetComputerScore(0);
        StartRound();
    }

    public void StartRound()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }

    public void PlayerScores()
    {
        SetPlayerScore(playerScore + 1);
        StartRound();
    }

    public void ComputerScores()
    {
        SetComputerScore(computerScore + 1);
        StartRound();
    }

    private void SetPlayerScore(int score)
    {
        playerScore = score;
        playerScoreText.text = score.ToString();
    }

    private void SetComputerScore(int score)
    {
        computerScore = score;
        computerScoreText.text = score.ToString();
    }

}
