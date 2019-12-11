using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Completed;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._Complete_Game.Scripts.Item
{
    public class PlayerInventory : MonoBehaviour
    {
        public Transform inventoryRoot;
        public List<Image> slots;
        public List<Item> items;
        public Sprite emptyImage;

        public TextMeshProUGUI leftFood;
        private bool isOpened = false;
        private int capacity = 2;
        private int occupacy = 0;

        void Update()
        {
            leftFood.text = GameManager.instance.playerFoodPoints.ToString();
        }

        public void IncreaseFood(int food)
        {
            GameManager.instance.playerFoodPoints += food;
        }

        public void OnOffInventory()
        {
            isOpened = !isOpened;
            inventoryRoot.gameObject.SetActive(isOpened);

            for (int i = 0; i < items.Count; i++)
            {
                slots[i].sprite = items[i].shape;
            }
        }

        public int CanHaveLeftInventory()
        {
            if (occupacy < capacity)
            {
                return occupacy;
            }
            else
            {
                return -1;
            }
        }
        public void GetItem(Item item, int slot)
        {
            items[slot] = item;
        }

        public void SellAll()
        {
            for (int i = 0; i < capacity; i++)
            {
                IncreaseFood(items[i].foodPrice);
                slots[i].sprite = emptyImage;
            }
        }
    }
}
