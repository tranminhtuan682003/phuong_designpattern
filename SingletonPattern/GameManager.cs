namespace phuong.baocao;

using System;

public class GameManager
{
    private static GameManager? instance;

    // Constructor riêng để đảm bảo Singleton
    private GameManager()
    {
        Score = 0;
        IsGamePaused = false;
    }

    // Property truy cập instance duy nhất
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }

    // Các thuộc tính và phương thức mở rộng

    /// <summary>
    /// Điểm số của người chơi.
    /// </summary>
    public int Score { get; private set; }

    /// <summary>
    /// Trạng thái của trò chơi (đang chơi hay tạm dừng).
    /// </summary>
    public bool IsGamePaused { get; private set; }

    /// <summary>
    /// Bắt đầu trò chơi, đặt lại điểm số và trạng thái.
    /// </summary>
    public void StartGame()
    {
        Score = 0;
        IsGamePaused = false;
        Console.WriteLine("Game Started!");
    }

    /// <summary>
    /// Tạm dừng trò chơi.
    /// </summary>
    public void PauseGame()
    {
        IsGamePaused = true;
        Console.WriteLine("Game Paused!");
    }

    /// <summary>
    /// Tiếp tục trò chơi nếu đang tạm dừng.
    /// </summary>
    public void ResumeGame()
    {
        if (IsGamePaused)
        {
            IsGamePaused = false;
            Console.WriteLine("Game Resumed!");
        }
    }

    /// <summary>
    /// Thêm điểm cho người chơi.
    /// </summary>
    public void AddScore(int points)
    {
        if (!IsGamePaused)
        {
            Score += points;
            Console.WriteLine($"Score: {Score}");
        }
    }

    /// <summary>
    /// Hiển thị điểm cuối cùng và kết thúc trò chơi.
    /// </summary>
    public void EndGame()
    {
        Console.WriteLine($"Game Over! Final Score: {Score}");
        IsGamePaused = true;
    }
}
