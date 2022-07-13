using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioSource[] se;

    private void Awake() //VOg»
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
    /// <summary>
    /// SEðÂç·(0:Q[I[o[ 1:ñ 2:íe 3:U 4:UI 5:RC
    /// </summary>
    /// <param name="x"></param>
    public void PlaySE(int x)
    {
        se[x].Stop();
        se[x].Play();
    }
}
