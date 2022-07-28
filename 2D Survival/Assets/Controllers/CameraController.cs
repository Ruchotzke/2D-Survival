using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Survival_2D.Controllers
{
    public class CameraController : MonoBehaviour
    {
        [Header("Sensitivity")]
        public float PanSpeed;
        public float MoveSpeed;

        [Header("Settings")]
        public Vector2 MarginArea = new Vector2(0.2f, 0.3f);

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            HandlePanning();
        }

        void HandlePanning()
        {
            /* Is the mouse in the pan region? */
            Vector2 mouseViewport = GetComponent<Camera>().ScreenToViewportPoint(Input.mousePosition);
            Vector2 panDirection = Vector2.zero;
            if(mouseViewport.x < MarginArea.x)
            {
                /* Pan left */
                panDirection += Vector2.left * (1.0f - mouseViewport.x / MarginArea.x);
            }

            if (mouseViewport.y < MarginArea.y)
            {
                /* Pan down */
                panDirection += Vector2.down * (1.0f - mouseViewport.y / MarginArea.y);
            }

            if (mouseViewport.x + MarginArea.x >= 1.0f)
            {
                /* Pan right */
                panDirection += Vector2.right * (1.0f - (1.0f - mouseViewport.x) / MarginArea.x);
            }

            if (mouseViewport.y + MarginArea.y >= 1.0f)
            {
                /* Pan up */
                panDirection += Vector2.up * (1.0f - (1.0f - mouseViewport.y) / MarginArea.y);
            }

            /* Pan the camera */
            if(panDirection.sqrMagnitude > 0)
            {
                Vector2 panAmount = panDirection * PanSpeed * Time.deltaTime;
                transform.position += (Vector3)panAmount;
            }
        }
    }
}
