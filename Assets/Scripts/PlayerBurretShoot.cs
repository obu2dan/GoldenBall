using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBurretShoot : MonoBehaviour
{
    [SerializeField]
    private float shot_rapid = 0.1f;

    private Transform p_tf;
    private BurretPool b_pool;
    private AudioSource shot_audio;
    [SerializeField]
    private AudioClip shot_SE;
    // Start is called before the first frame update
    void Start()
    {
        b_pool = GameObject.Find("burret_pool").GetComponent<BurretPool>();
        p_tf = this.transform;
        StartCoroutine(ShotBurret());
        shot_audio = GetComponent<AudioSource>();
    }

IEnumerator ShotBurret()
{
while (true)
    {  
			// 弾を撃つ処理を呼んで
		Shot();  
         // shot_rapid秒待つ
        yield return new WaitForSeconds (shot_rapid);    
    } 
}

private void Shot()
{
    if(Input.GetKey(KeyCode.Z)){
        shot_audio.PlayOneShot(shot_SE);
        var burret = b_pool.GetBurret();
		burret.transform.localPosition = p_tf.position;
    }
}
// Update is called once per frame
    void Update()
    {
        
    }
}
