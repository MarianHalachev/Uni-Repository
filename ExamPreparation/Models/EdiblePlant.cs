using System;
using System.Collections.Generic;
using System.Text;
using ExamPreparation.Interfaces;

namespace ExamPreparation.Models
{
    public class EdiblePlant : Plant, IFood
    {
        public virtual double Energy { get; }
    }
}
