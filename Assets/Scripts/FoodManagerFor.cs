using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManagerFor : MonoBehaviour
{
      public GameObject FoodPrefab;
      // public Vector2 FieldSize = new Vector2(40, 40);
      // public Vector2 FieldPos = new Vector2(-20, 0);     
      public Transform ObjectTopRightBorder, ObjectBotLeftBorder;
      private GameObject Food;

      public void CreateNewFood()
      {
            if (FoodPrefab != null)
            {
                  Food = Instantiate(FoodPrefab, transform);
                  Vector3 positionfood = new Vector3(Random.Range(ObjectBotLeftBorder.localPosition.x, ObjectTopRightBorder.localPosition.x), 1, Random.Range(ObjectBotLeftBorder.localPosition.z, ObjectTopRightBorder.localPosition.z));
                  Food.transform.localPosition = positionfood;
            }

      }

      private void Start()
      {
            CreateNewFood();
      }
}
