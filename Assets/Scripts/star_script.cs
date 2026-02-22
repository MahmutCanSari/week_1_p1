    using Unity.Mathematics;
    using UnityEngine;

    public class star_script : MonoBehaviour
    {
        Vector2 star_location = Vector2.zero;
        public float star_scale = 0.002f;


        void Start()
        {
            Let_be_light();
        }

        void Update()
        {
            star_location.x = star_location.x + star_location.x * star_scale;
            star_location.y = star_location.y + star_location.y * star_scale;
            
            transform.localPosition = star_location;
            
            Star_size();

            if ((star_location.x > 9 || star_location.x < -9) || (star_location.y > 5 || star_location.y < -5))
            {
                Let_be_light();
            }
        }
   

        void Let_be_light() 
        {
            star_location.x = UnityEngine.Random.Range(0f, 1f) * (UnityEngine.Random.Range(0, 2) * 2 - 1);
            star_location.y = UnityEngine.Random.Range(0f, 1f) * (UnityEngine.Random.Range(0, 2) * 2 - 1);   

            Star_size();
            
            GetComponent<Renderer>().material.color = new Color(UnityEngine.Random.Range(0.6f, 1f), UnityEngine.Random.Range(0.6f, 1f), UnityEngine.Random.Range(0.6f, 1f), 1f);

        }

        void Star_size() 
        {
            float added_loc = math.abs(star_location.x) + math.abs(star_location.y);
            transform.localScale = new Vector3(added_loc/18, added_loc/18, 1f);
        }
    }
