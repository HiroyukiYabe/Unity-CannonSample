using UnityEngine;
using System.Collections;

public class CubeCreator : MonoBehaviour {

	public GameObject Cube;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//エンターでインスタンス生成
		if(Input.GetMouseButtonDown(0))
		Instantiate(Cube,transform.position,Quaternion.identity);
	}
}
