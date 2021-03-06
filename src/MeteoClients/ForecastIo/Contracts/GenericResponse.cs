﻿// The MIT License (MIT)
// 
// Copyright (c) 2016 Volodymyr Gotra
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
using System.Collections.Generic;

namespace MeteoClients.ForecastIo.Contracts
{
    public class GenericResponse
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Timezone { get; set; }
        public float Offset { get; set; }
        public Currently Currently { get; set; }
        public Minutely Minutely { get; set; }
        public Hourly Hourly { get; set; }
        public Daily Daily { get; set; }
        public List<Alert> Alerts { get; set; }
        public Flags Flags { get; set; }
        public int NumberOfCalls { get; set; }
    }
}