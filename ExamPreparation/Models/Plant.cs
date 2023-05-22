using System;
using System.Collections.Generic;
using System.Text;
using ExamPreparation.Interfaces;

namespace ExamPreparation.Models
{
    public abstract class Plant : IGardenItem
    {
        public virtual double WaterRequired { get; }
    }
}
