using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 offset = new Vector3(0, 6, -7);
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        //Kamerayı bu şekilde hareket ettirebilriz ancak kamerayı tekrar calculation yaptırmamak için player objesinin içine koyup orada da hareket ettirebilirz.
        //tabi lateUpdate daha onemlidir. rahatsız edici bir donukluk olur update yaptığımız zaman
    }
}
