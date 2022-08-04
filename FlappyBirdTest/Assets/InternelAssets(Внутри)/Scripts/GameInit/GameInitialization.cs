using System.Collections;
using UnityEngine;

namespace FlappyBird.Mechanics
{
    public sealed class GameInitialization : MonoBehaviour
    {
        public GameDataContainer dataInitialization;
        public PipeControler pipeControler;

        private void Awake()
        {
            if (pipeControler == null)
            {
                pipeControler = FindObjectOfType<PipeControler>();
            }

            if (dataInitialization == null)
            {
                dataInitialization = FindObjectOfType<GameDataContainer>();
            }
        }

        private void Start()
        {
            Init();
        }

        public void Init()
        {
            dataInitialization.gameCurrence.coins = 0;
            var bird = GameObject.FindGameObjectWithTag("Player");
            Destroy(bird);
            dataInitialization.pipeConfig.isSpawnPipe = true;

            dataInitialization.UIConfig.panel.SetActive(false);

             
            GameObject player = Instantiate(dataInitialization.birdConfig.birdPrefab, dataInitialization.birdSpawnPoint, Quaternion.identity);
            player.AddComponent<Rigidbody2D>().velocity = Vector2.up * dataInitialization.birdConfig.powerJump;

            dataInitialization.birdConfig.birdRigidbody = player.GetComponent<Rigidbody2D>();
            var temp =  GameObject.FindObjectOfType<PipeControler>();
            Destroy(temp);
            Destroy(GameObject.Find("PipeControler"));
            new GameObject("PipeControler").AddComponent<PipeControler>();



        }
    }
}