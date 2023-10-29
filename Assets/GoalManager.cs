using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GoalManager : MonoBehaviour
{
    // ScoreTextを使えるようにする
    //private ScoreText scoreText;
    public GameObject scoreObject;
    ScoreText scoreText;

    // フィールドの初期化
    void Start()
    {
        // FindObjectOfTypeは非推奨
        //scoreText = FindObjectOfType<ScoreText>();

        // 他のscriptの値を使えるようにする 
        scoreObject = GameObject.Find("Text (Legacy)");
        scoreText = scoreObject.GetComponent<ScoreText>();
    }

    // 画面外に出たら削除処理
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    // すり抜けた場合の処理
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("すり抜けた！");

        if (scoreText != null && collision != null)
        {
            scoreText.AddScore();
        }

    }
}
