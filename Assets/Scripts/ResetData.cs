using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetData : MonoBehaviour
{
    // Start is called before the first frame update
    public void ClearData()
    {
        SaveController.Instance.ClearSave();
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
