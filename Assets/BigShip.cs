using UnityEngine;
using Homebrew;

public class BigShip : MonoBehaviour, ITick {

    private void Awake()
    {
        ManagerUpdate.AddTo(this);
    }
    public void Tick()
    {
        Debug.Log("I'm a zombie");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Toolbox.Get<ManagerEvents>().CreatePrefab(Random.insideUnitSphere * Random.Range(-10, 10));
        }
    }


}
