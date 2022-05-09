using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public bool On;

    [SerializeField] GameObject Shard;
    [SerializeField] GameObject[] SpecialShard;
    [SerializeField] float CD_Count, CD_BaseValue;
    [SerializeField] int ShardNumber, SpS_Timer, selection;
    [SerializeField] float Timer;
    
    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;
        ShardNumber = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Timer += 1 * Time.deltaTime;
        if (CD_Count <= 0)
        {
            if (SpS_Timer == 5)
            {
                int i = 0;
                selection = Random.Range(0, 2);
                while (i < Mathf.Round(ShardNumber / 2))
                {
                    Instantiate(SpecialShard[selection]);
                    i++;
                }
                CD_Count = CD_BaseValue;
                SpS_Timer = 0;
            }
            else
            {
                int i = 0;
                while (i < ShardNumber)
                {
                    Instantiate(Shard);
                    i++;
                }
                CD_Count = CD_BaseValue;
                SpS_Timer++;
            }

        }
        CD_Count -= 1 * Time.deltaTime;

        if (Timer > 2 * ShardNumber && ShardNumber < 11)
        {
            ShardNumber++;
            Timer = 0;
        }
    }
    
}
