﻿using Microsoft.Band.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unBand.BandHelpers.Sensors;

namespace unBand.BandHelpers
{
    class BandSensors
    {

        private CargoClient _client;

        public BandPedometer Pedometer { get; set; }

        public BandSensors(CargoClient client)
        {
            _client = client;
        }

        public async Task InitAsync()
        {
            Pedometer = new BandPedometer(_client);
            await Pedometer.InitAsync();
        }

    }
}
