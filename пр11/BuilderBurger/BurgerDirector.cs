﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using пр11.BuilderBurger;

namespace пр11.BuilderBurger
{
    public class BurgerDirector
    {
        private readonly IBurgerBuilder _builder;

        public BurgerDirector(IBurgerBuilder builder)
        {
            _builder = builder;
        }
        public void BuilderDefault()
        {
            _builder
            .AddCheese()
            .AddTomato()
            .AddPickles();
        }
        public void BuildWithBeacon()
        {
            _builder
            .AddTomato()
            .AddBacon()
            .AddLetuce();
        }
    }
}
