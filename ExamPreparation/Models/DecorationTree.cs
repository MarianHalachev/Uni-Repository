using System;
using System.Collections.Generic;
using System.Text;
using ExamPreparation.Interfaces;

namespace ExamPreparation.Models
{
    public abstract class DecorationTree : Tree, IBeauty
    {
        public virtual double BeautyScore { get; }
    }
}
