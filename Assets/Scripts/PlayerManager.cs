using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class PlayerManager : MonoBehaviour
{
    public string playerName;
    public string bestPlayerName;
    public int bestScore;

    public static PlayerManager Instance;
    public string PlayerName {set => playerName = value;}

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadBestScore();
    }

    [System.Serializable]
    class SaveData
    {
        public string PlayerName;
        public int Score;
    }

    public void SaveBestScore()
    {
        SaveData data = new SaveData();
        bestPlayerName = playerName;
        data.PlayerName = bestPlayerName;
        data.Score = bestScore;

        string json = JsonUtility.ToJson(data);
    
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadBestScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestPlayerName = data.PlayerName;
            bestScore = data.Score;
        }
    }
}
