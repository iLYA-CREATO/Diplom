
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelGame : MonoBehaviour
{
    public string OneLevel;
    public string TwoLevel;
    public List<GameObject> MiniGame;
    public int IdGame;

    public List<GameObject> ButtonNextLevel;

    public void Start()
    {
        IdGame = 0;
    }

    public void GameVisable()
    {
        switch (IdGame)
        {
            case 0:
                ButtonNextLevel[0].SetActive(false);//  нопка сены уровн€
                ButtonNextLevel[1].SetActive(true);//  нопка сены уровн€
                MiniGame[IdGame].SetActive(true);
                MiniGame[IdGame + 1].SetActive(false);
                break;
            case 1:
                ButtonNextLevel[0].SetActive(true);//  нопка сены уровн€
                ButtonNextLevel[1].SetActive(false);//  нопка сены уровн€
                MiniGame[IdGame].SetActive(true);
                MiniGame[IdGame - 1].SetActive(false);
                break;
        }
    }
    public void Update()
    {
        GameVisable();
    }
    public void LeftGame()
    {
        if(IdGame > 0)
            IdGame--;
    }
    public void RightGame()
    {
        if (IdGame < MiniGame.Count)
            IdGame++;
    }

    public void OpenLevel()
    {
        if(IdGame == 0)
        {
            SceneManager.LoadScene(OneLevel);
        }
        else if(IdGame == 1)
        {
            SceneManager.LoadScene(TwoLevel);
        }
    }
}

