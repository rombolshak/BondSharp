using System;

namespace BondSharp
{
    [Serializable]
    public class Bond
    {
        public string Ticker { get; set; }
        public decimal FaceValue { get; set; }
    }
}