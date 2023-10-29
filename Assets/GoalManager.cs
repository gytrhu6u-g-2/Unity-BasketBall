using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalManager : MonoBehaviour
{
    // ScoreTextを使えるようにする
    private ScoreText scoreText;

    // フィールドの初期化
    void Start()
    {
        scoreText = FindObjectOfType<ScoreText>();
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

        if (collision != null)
        {
            scoreText.AddScore();
        }

    }
}
