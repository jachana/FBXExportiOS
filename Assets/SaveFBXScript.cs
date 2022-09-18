using System.IO;
using UnityEngine;


public class SaveFBXScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ExportDragon()
    {
        string filePath = Path.Combine(Application.dataPath, "Dragon.fbx");
    }

}
