using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets._Complete_Game.Scripts.Item
{
    public class Item : MonoBehaviour
    {
        public Item(Sprite shape, int price)
        {
            this.shape = shape;
            this.foodPrice = price;
        }

        public Sprite shape;
        public int foodPrice;
    }
}