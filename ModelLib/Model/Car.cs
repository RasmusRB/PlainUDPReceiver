using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib.Model
{
    public class Car
    {
        private string Model { get; set; }
        private string Color { get; set; }
        private string RegistrationNr { get; set; }

        public Car()
        {
        }

        public Car(string model, string color, string registrationNr)
        {
            Model = model;
            Color = color;
            RegistrationNr = registrationNr;
        }

        public override string ToString()
        {
            return $"{nameof(Model)}: {Model}, {nameof(Color)}: {Color}, {nameof(RegistrationNr)}: {RegistrationNr}";
        }
    }
}
