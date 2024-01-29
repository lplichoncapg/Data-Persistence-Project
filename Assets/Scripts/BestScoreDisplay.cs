using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestScoreDisplay : MonoBehaviour
{
    public TMP_Text bestScoreText;

    void Awake(){
        bestScoreText = GetComponent<TMP_Text>();
    }

    // Start is called before the first frame update
    void Start()
    {
        bestScoreText.text = "Best score : " + PlayerManager.Instance.bestScore;
    }

}
