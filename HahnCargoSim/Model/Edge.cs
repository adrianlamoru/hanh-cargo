﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HahnCargoSim.Model
{
  public class Edge
  {
    public int Id { get; set; }
    public int Cost { get; set; }
    public TimeSpan Time { get; set; }
  }
}
