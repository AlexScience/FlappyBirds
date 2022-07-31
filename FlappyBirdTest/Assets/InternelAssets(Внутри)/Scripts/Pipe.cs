using System.Collections;
using UnityEngine;

namespace Assets
{
    public class Pipe : MonoBehaviour
    {
        public DataContainer container;

        private void Awake()
        {
            if (container == null)
            {
                container = FindObjectOfType<DataContainer>();
            }
        }
        void Update()
        {
            transform.Translate(Vector2.left * container.pipeSpeed*Time.deltaTime);

        }
    }
}