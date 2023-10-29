using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    // textを使えるようにする
    private Text text;
    // スコア
    public int score = 1;

    // Start is called before the first frame update
    void Start()
    {
        // コンポーネント取得
        text = gameObject.GetComponent<Text>();
    }

    // スコアに得点を加算する
    public void AddScore()
    {
        text.text = "スコア：" + score.ToString();
        score++;
    }
}
