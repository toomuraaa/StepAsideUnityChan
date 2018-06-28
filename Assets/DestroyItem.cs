using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItem : MonoBehaviour {

    private GameObject unitychan;

    // Use this for initialization
	void Start () {
        //unitychanを取得
        this.unitychan = GameObject.Find("unitychan");
    }
	
	// Update is called once per frame
	void Update () {
        
        //条件を満たせばオブジェクトを削除
        if (this.transform.position.z <= unitychan.transform.position.z)
        {
            Destroy(gameObject,3.0f);
        }
	}
}
