using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackManager : MonoBehaviour
{
    public GameObject goalPrefab;

    // Start is called before the first frame update
    void Start()
    {
        // 第二引数：ゲームが実行されて何秒後　第三引数：第二引数からの間隔
        InvokeRepeating("AppearanceGoal", 0f, 6f);
    }

    // Update is called once per frame
    void Update()
    {
        // x軸にスクロールさせる
        transform.position += new Vector3(2 * Time.deltaTime, 0, 0);
    }

    // ゴールをランダムで表示
    private void AppearanceGoal()
    {
        // 生成場所
        Vector2 random = new Vector2(transform.position.x + 8, Random.Range(-3f, 3f));
        // 第三引数：回転させないようにする
        Instantiate(goalPrefab, random, Quaternion.identity);
    }
}
