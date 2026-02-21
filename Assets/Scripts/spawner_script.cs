using UnityEngine;

public class spawner_script : MonoBehaviour
{
    public GameObject star;
    public int star_num = 0;

    void Start()
    {   
        for (int i = 0; i < star_num; i++)
        {
            Instantiate(star);
        }
    }
}
