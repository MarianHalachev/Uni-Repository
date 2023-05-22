using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ExamPreparation.Interfaces;

namespace ExamPreparation.Models
{
    public class Garden
    {
        public List<IGardenItem> Items { get; set; } = new List<IGardenItem>();
        public List<IBeauty> Beauties
        {
            get
            {
                return Items.Where(i => i is IBeauty)
                            .Select(x => (IBeauty)x)
                            .ToList();
            }
        }
        public List<IFood> Foods
        {
            get
            {
                return Items.Where(i => i is IFood)
                            .Select(x => (IFood)x)
                            .ToList();
            }
        }
    }
}
