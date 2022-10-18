﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppClimaAPI.Model
{
    public class Clima
    {
        public string Title { get; set; }
        public string Temperature { get; set; }
        public string Wind { get; set; }
        public string Humidity { get; set; }
        public string Visibility { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }

        public Clima()
        {
            // string vazia ao qual será inserido os dados
            this.Title = " ";
            this.Temperature = " ";
            this.Wind = " ";
            this.Humidity = " ";
            this.Visibility = " ";
            this.Sunrise = " ";
            this.Sunset = " ";

        }

    }

}
