using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*課題部分
public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 配列を初期化する
		int[] array = new int[5];

		array [0] = 1;
		array [1] = 3;
		array [2] = 5;
		array [3] = 7;
		array [4] = 9;

		for(int i=0; i<5; i++){
			Debug.Log (array [i]);
		}

		for(int i=4; i>=0; i--) {
			Debug.Log (array [i]);
		}
	}
*/

public class Boss {        
	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力
	public int mp = 53; //魔法攻撃

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	//魔法用
	public void Magic(){
		if (mp > 5) {
			mp = mp - 5;
			Debug.Log ("魔法攻撃した。残り魔法MPは" + this.mp);
		} else {
			Debug.Log ("MPが足りません");
		}
	}


	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

}

public class Test : MonoBehaviour {

	void Start () {

		int[] array = new int[5];

		array [0] = 1;
		array [1] = 3;
		array [2] = 5;
		array [3] = 7;
		array [4] = 9;

		for(int i=0; i<5; i++){
			Debug.Log (array [i]);
		}

		for(int i=4; i>=0; i--) {
			Debug.Log (array [i]);
		}
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		// 攻撃用の関数を呼び出す
		lastboss.Attack ();
		// 防御用の関数を呼び出す
		lastboss.Defence (3);
		// 魔法用
		for (int i = 0; i < 10; i++) {
			lastboss.Magic ();
		}
	}
			

	// Update is called once per frame
	void Update () {

	}
}
	