using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Mid_Project.DL
{
    internal class AddConsumableDL
    {
     
        public class ConsumableDL
        {
            public static int AddConsumable(string itemName)
            {
                string query = $"INSERT INTO consumables (item_name) VALUES ('{itemName}')";
                return DatabaseHelper.Instance.Update(query);
            }
        }
    }


}

