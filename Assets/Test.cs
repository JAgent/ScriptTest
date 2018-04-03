using UnityEngine;
using System.Collections;

// public class Test : MonoBehaviour {
//
	// Use this for initialization
//	void Start () {
//		// 配列を初期化する
//		int[] points = {30, 20, 50, 10, 80, 15, 60, 100};
//
//		// 配列の要素数のぶんだけ処理を繰り返す
//		for (int i = 0; i < points.Length; i++) {
//			// 配列の要素が50以上の場合
//			if( points[i] >= 50 ){
//				// 配列の要素を表示する
//				Debug.Log (points [i]);
//			}
//		}
//	}
//
//	// Update is called once per frame
//	void Update () {
//
//	}
// }

public class Boss {        
	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力
	private int mp = 53; //魔法力

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}
	// 魔法攻撃用の関数
	public  void Magic() {
		if (mp >= 5) {
	// MPを５減らす
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp);
		} 
		else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
}

public class Test : MonoBehaviour {

	void Start () {
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		// 攻撃用の関数を呼び出す
		lastboss.Attack();
		// 防御用の関数を呼び出す
		lastboss.Defence(3);
		// 魔法攻撃用の関数を呼び出す
		for (int i = 0; i < 11; i++) {
			// 配列の要素が50以上の場合
			lastboss.Magic();
		}
	}

	// Update is called once per frame
	void Update () {

	}
}