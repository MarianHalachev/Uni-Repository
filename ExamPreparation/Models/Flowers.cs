using System;
using System.Collections.Generic;
using System.Text;
using ExamPreparation.Interfaces;

namespace ExamPreparation.Models
{
    public abstract class Flowers : Plant, IBeauty
    {
        public virtual double BeautyScore { get; }
    }
}
