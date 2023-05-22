using System;
using System.Collections.Generic;
using System.Text;
using ExamPreparation.Interfaces;

namespace ExamPreparation.Models
{
    public abstract class Tree : IGardenItem
    {
        public virtual double WaterRequired { get; }
    }
}
