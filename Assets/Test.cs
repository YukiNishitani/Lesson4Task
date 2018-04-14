using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // 配列を初期化する
        int[] points = { 30, 20, 50, 10, 80, 15, 60, 100 };

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int i = 0; i < points.Length; i++){
            // 配列の要素が50以上の場合
            if( points[i] >= 50 ){
                //　配列の要素を表示する
                Debug.Log(points[i]);
            }
        }

        //課題：配列を宣言して出力しましょう
        int[] array = { 1, 2, 3, 4, 5 };
        // 配列の各要素の値を順番に表示
        for (int i = 0; i <= 4; ++i){
            Debug.Log(array[i]);
        }
            // 配列の各要素の値を逆順に表示
            for (int i = 4; i >= 0; --i){
            Debug.Log(array[i]);
            }
        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
