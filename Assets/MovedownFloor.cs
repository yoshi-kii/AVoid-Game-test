using UnityEngine;
using System.Collections;

public class MovedownFloor : MonoBehaviour
{

    private Vector3 pos;

    void Start()
    {

        // MoveFloor2オブジェクトの位置情報をposの中に代入する。
        pos = transform.position;
    }

    void Update()
    {


        this.gameObject.transform.position = new Vector3(pos.x, pos.y - Mathf.PingPong(Time.time, 5), pos.z);

    }
}