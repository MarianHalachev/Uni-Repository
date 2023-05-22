using System;
using System.Collections.Generic;
using System.Text;
using ExamPreparation.Interfaces;

namespace ExamPreparation.Models
{
    public abstract class FruitTree : Tree, IFood
    {
        public virtual double Energy { get; }
    }
}
