using System;
using System.Collections.Generic;
using System.Text;

namespace ExamPreparation.Models
{
    public class Rose : Flowers
    {
        public override double BeautyScore => 15;
        public override double WaterRequired => 5;
    }
}
