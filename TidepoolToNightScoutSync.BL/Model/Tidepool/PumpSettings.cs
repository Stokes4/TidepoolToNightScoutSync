﻿using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace TidepoolToNightScoutSync.BL.Model.Tidepool
{
    public class PumpSettings
    {
        [JsonProperty("activeSchedule")]
        public string? ActiveSchedule { get; set; }

        [JsonProperty("automatedDelivery")]
        public bool AutomatedDelivery { get; set; }

        [JsonProperty("deviceTime")]
        public DateTime? DeviceTime { get; set; }

        [JsonProperty("basalSchedules")]
        public IReadOnlyDictionary<string, IReadOnlyList<BasalSchedule>> BasalSchedules { get; set; } = new Dictionary<string, IReadOnlyList<BasalSchedule>>();

        [JsonProperty("units")]
        public Unit Units { get; set; } = new Unit();
    }
}