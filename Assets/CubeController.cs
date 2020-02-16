using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour 
{
	// キューブの移動速度
	private float speed = -12;

	// 消滅位置
	private float deadLine = -10;

	//キューブが地面と接するときの音　
	AudioSource myaudiosource;


	// Use this for initialization
	void Start()
	{
		//オーディオコンポーネントのの取得　
		this.myaudiosource = GetComponent<AudioSource> (); 
	}

	// Update is called once per frame
	void Update () 
	{
		// キューブを移動させる
		transform.Translate (this.speed* Time.deltaTime, 0, 0);

		// 画面外に出たら破棄する
		if (transform.position.x < this.deadLine)
		{
			Destroy (gameObject);
		}
	
	
	}

	//キューブが地面と接触しているとき
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "GrTag")
		{
			//音を鳴らす　
			myaudiosource.Play ();

		}

		if (other.gameObject.tag == "CubeTag")
		{
			//音を鳴らす　
			myaudiosource.Play ();

		}
	}

}
