using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    private AudioSource title_sound;
    [SerializeField]
    private AudioClip title_se;
    private bool is_se = true;
    // Start is called before the first frame update
    void Start()
    {
        title_sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && is_se){
            title_sound.PlayOneShot(title_se);
            is_se = false;
            StartCoroutine(TitleScene(0.5f));
        }
    }
    IEnumerator TitleScene(float wait_time)
    {
        yield return new WaitForSeconds(wait_time);
        SceneManager.LoadScene(1);
    }
}
