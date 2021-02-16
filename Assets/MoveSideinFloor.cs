using UnityEngine;
using System.Collections;

public class MoveSideinFloor : MonoBehaviour
{

    private Vector3 pos;

    void Start()
    {

        // MoveFloor2オブジェクトの位置情報をposの中に代入する。
        pos = transform.position;
    }

    void Update()
    {


        this.gameObject.transform.position = new Vector3(pos.x - Mathf.PingPong(Time.time, 5), pos.y, pos.z);

    }
}

