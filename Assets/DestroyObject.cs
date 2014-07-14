using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//画面外に消えたらオブジェクトを破棄
	void OnBecameInvisible () 
	{
		Destroy(this.gameObject);
	}

}
