using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace C__Project
{
    public class RollDice
    {
        private Random rnd= new Random();
        private int[] rolls = new int[19]; // Holds 3 to 18 

        public int OneDice() {
            return rnd.Next(6)+1;
        }

        public int ThreeDice()
        {
            return OneDice() + OneDice() + OneDice() ;
        }


 }

    
  }