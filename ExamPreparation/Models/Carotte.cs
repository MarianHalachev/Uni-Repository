using System;
using System.Collections.Generic;
using System.Text;

namespace ExamPreparation.Models
{
    public class Carotte : EdiblePlant
    {
        public override double Energy => 10;
        public override double WaterRequired => 1;
    }
}
