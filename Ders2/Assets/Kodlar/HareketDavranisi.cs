using System.Collections;
using System.Collections.Generic;
using UnityEngine; //unity engine import

/*  KAYNAK DOCUMENTATION
    https://docs.unity3d.com/ScriptReference/30_search.html?q=transform
*/

public class HareketDavranisi : MonoBehaviour //mono behaviourdan extend oluyor
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(1,0,0);
    }
}
