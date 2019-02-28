//  This file was created by Kamil KAYA
//  Ozyegin University - Electric Electronic Engineering
//  www.kamilkaya.com.tr

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirimCevirici
{
    class convertorClass
    {
        
        public double calculateLength(double input, double input_coefficient, double output_coefficient, bool position)
        {
            if (!position)
            {
                return (input * input_coefficient* output_coefficient);

            }
            else {
                return ((input / input_coefficient) /output_coefficient);
                
            }
        }

        public double calculateArea(double input, double input_coefficient, double output_coefficient, bool position)
        {

            if (!position)
            {
                return (input * input_coefficient * output_coefficient);

            }
            else
            {
                return ((input / input_coefficient) / output_coefficient);

            }
        }

        public double calculateVolume(double input, double input_coefficient, double output_coefficient, bool position)
        {
            if (!position)
            {
                return (input * input_coefficient * output_coefficient);

            }
            else
            {
                return ((input / input_coefficient) / output_coefficient);

            }
        }

        public double calculateSquareArea(double input, double input_coefficient, double output_coefficient, bool position)
        {
            if (!position)
            {
                return (input * input_coefficient * output_coefficient);

            }
            else
            {
                return ((input / input_coefficient) / output_coefficient);

            }
        }

        public double calculateMass(double input, double input_coefficient, double output_coefficient, bool position)
        {
            if (!position)
            {
                return (input * input_coefficient * output_coefficient);

            }
            else
            {
                return ((input / input_coefficient) / output_coefficient);

            }
        }

        public double calculateDensity(double input, double input_coefficient, double output_coefficient, bool position)
        {
            if (!position)
            {
                return (input * input_coefficient * output_coefficient);

            }
            else
            {
                return ((input / input_coefficient) / output_coefficient);

            }
        }

        public double calculateForce(double input, double input_coefficient, double output_coefficient, bool position)
        {
            if (!position)
            {
                return (input * input_coefficient * output_coefficient);

            }
            else
            {
                return ((input / input_coefficient) / output_coefficient);

            }
        }

        public double calculateMoment(double input, double input_coefficient, double output_coefficient, bool position)
        {
            if (!position)
            {
                return (input * input_coefficient * output_coefficient);

            }
            else
            {
                return ((input / input_coefficient) / output_coefficient);

            }
        }

        public double calculatePressure(double input, double input_coefficient, double output_coefficient, bool position)
        {
            if (!position)
            {
                return (input * input_coefficient * output_coefficient);

            }
            else
            {
                return ((input / input_coefficient) / output_coefficient);

            }

        }
        public double calculateTemparature(double input, bool position)
        {
            if (!position)
            {
                return (((9.0/5.0)*input)+32);

            }
            else
            {
                return ((5.0/9.0)*(input-32));

            }

        }
    }
}
