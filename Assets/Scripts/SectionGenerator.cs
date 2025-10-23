using System.Collections;
using UnityEngine;

public class SectionGenerator : MonoBehaviour
{
    public GameObject[] firstSection;
    [SerializeField] int zPos = 50;
    [SerializeField] bool creatingSection = false;
    [SerializeField] int sectionNum;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if(creatingSection ==false)
        {
            creatingSection = true;
            StartCoroutine(sectionGen());
        }
        
        
    }

    IEnumerator sectionGen()
    {
        sectionNum = Random.Range(0, 2);
        Instantiate(firstSection[sectionNum], new Vector3 (0,0,zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(5);
        creatingSection=false;
    }

}
