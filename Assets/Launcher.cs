using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {

	public GameObject Shell;
	
	// Use this for initialization
	void Start () {
		//Shell = GameObject.Find("Shell");
	}

	// Update is called once per frame
	void Update () {
		//スペースでインスタンス生成
		if(Input.GetKeyUp(KeyCode.Space))
			Instantiate(Shell,transform.position,Quaternion.identity);
	}
}
