using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameData Data;
    public List<CardData> myDatabase;
    public List<CardData> myHand;
    void Start()
    {
        for (int i = 0; i < Data.startHandCount; i++)
        {
            int _random = Random.Range(0, myDatabase.Count);
            CardData _Data = myDatabase[_random];
            myHand.Add(_Data);
            GameObject _obj = Instantiate(_Data.Prefab);
            SpriteRenderer _render = _obj.GetComponent<SpriteRenderer>();
            _render.sprite = _Data.Picture;

            _obj.transform.position -= new Vector3(_obj.transform.position.x - Random.Range(-10f, 10),0f,0f);

        }
    }


}
