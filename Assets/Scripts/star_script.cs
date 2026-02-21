    using Unity.Mathematics;
    using UnityEngine;

    public class star_script : MonoBehaviour
    {
        Vector2 star_location = Vector2.zero;
        Vector2 star_location_last = Vector2.zero;
        public float star_scale = 0.002f;
        private LineRenderer lineRenderer;


        void Start()
        {
            lineRenderer = gameObject.AddComponent<LineRenderer>();
            lineRenderer.positionCount = 2;
            lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
            lineRenderer.startWidth = 1f;
            lineRenderer.endWidth = 1f;
            Let_be_light();
        }

        void Update()
        {

            
        
            star_location.x = star_location.x + star_location.x * star_scale;
            star_location.y = star_location.y + star_location.y * star_scale;

            lineRenderer.SetPosition(0, star_location_last);
            lineRenderer.SetPosition(1, star_location);
            transform.localPosition = star_location;
            star_location_last = star_location;
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
            lineRenderer.SetPosition(0, star_location_last);    
            transform.localPosition = star_location;

            Star_size();
        
            GetComponent<Renderer>().material.color = new Color(UnityEngine.Random.Range(0.6f, 1f), UnityEngine.Random.Range(0.6f, 1f), UnityEngine.Random.Range(0.6f, 1f), 1f);
            lineRenderer.startColor = Color.white;
            lineRenderer.endColor = Color.white;
        }

        void Star_size() 
        {
            //lineRenderer.startWidth =transform.localScale.x; 
            float added_loc = math.abs(star_location.x) + math.abs(star_location.y);
            transform.localScale = new Vector3(added_loc/18, added_loc/18, 1f);
            //lineRenderer.endWidth = transform.localScale.x;
        }
    }
