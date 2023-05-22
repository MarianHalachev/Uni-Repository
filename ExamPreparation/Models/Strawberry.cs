using System;
using System.Collections.Generic;
using System.Text;

namespace ExamPreparation.Models
{
    public class Strawberry : EdiblePlant
    {
        public override double Energy => 12;
        public override double WaterRequired => 3;
    }
}
