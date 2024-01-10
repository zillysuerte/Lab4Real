﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Real
{
    public class SolutionsData
    {
        //private List<Solution> solutions;

        public SolutionsData()
        {
           
        }
        public double A {  get; set; }
        public double B { get; set; }
        public double C { get; set; }
        [Key]
        public int Id { get; set; }
        public int NumberOfRoots { get; set; }
        public double Root1 { get; set; }
        public double Root2 { get; set; }
        /*public void Add(Solution solution)
        {
            solutions.Add(solution);
        }
        public IEnumerable<Solution> Items()
        {
            return solutions;
        }*/
    }
}
