using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurretPool : MonoBehaviour
{   
    [SerializeField]
    private GameObject burret_obj; // プールするオブジェクト。ここでは弾
	private List<GameObject> pool_list; // 生成した弾用のリスト。このリストの中から未使用のものを探したりする
	private const int b_count = 10; // 最初に生成する弾の数 

    // Start is called before the first frame update
    void Start()
    {
        CreatePool();
    }
    private void CreatePool()
	{
        pool_list = new List<GameObject>();
        for (int i = 0; i < b_count; i++) 
		{
            var new_obj = CreateNewBurret(); // 弾を生成して
			new_obj.GetComponent<Rigidbody2D>().simulated = false; // 物理演算を切って(=未使用にして)
            pool_list.Add(new_obj); // リストに保存しておく
        }
    }
    public GameObject GetBurret()
	{
        // 使用中でないものを探して返す
        foreach (var obj in pool_list)
		{
			var obj_rb = obj.GetComponent<Rigidbody2D>();
            if (obj_rb.simulated  == false) 
			{
				obj_rb.simulated = true;
                return obj;
            }
        }
        var new_obj = CreateNewBurret();
        pool_list.Add(new_obj);
 
		new_obj.GetComponent<Rigidbody2D>().simulated = true;
        return new_obj;
    }
    private GameObject CreateNewBurret(){
		var pos = new Vector2(100,100); // 画面外であればどこでもOK
        var new_obj = Instantiate(burret_obj, pos, Quaternion.identity); // 弾を生成しておいて
        new_obj.name = burret_obj.name + (pool_list.Count + 1); // 名前を連番でつけてから
 
        return new_obj; // 返す
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
