using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform player;
    public float ahead = 3f;//X轴最大变量
    public float speed = 1f;//速度
    public float smooth = 2.5f;//平滑度
    public float minX = 0f;
    public float maxX = 40.3f;

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector3 targetPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            if (player.position.x > minX && player.position.x < maxX)
            {
                if (Mathf.Abs(transform.position.x - player.position.x) > ahead)
                {
                    if (transform.position.x > player.position.x)
                    {
                        targetPos = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
                    }
                    else
                    {
                        targetPos = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
                    }
                }
            }

            transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * smooth);
            Debug.Log(player.position.x);
        }
    }
}
