using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceTask.Models
{
    abstract class Vehicle
    {
        private string _factoryName;
        private string _color;
        private string _model;
        private double _driveTime;
        private double _drivePath;

        public string FactoryName
        {
            get { return _factoryName; }
            set
            {
                value = value.Trim();
                if(value.Length > 1)
                {
                    _factoryName = value;
                }
               
            }

        }
        public string Model
        {
            get { return _model; }
            set
            {
                value = value.Trim();
                if (value.Length >= 1)
                {
                    _model = value;
                }

            }

        }
     
        public string Color
        {
            get { return _color; }
            set
            {
                value = value.Trim();
                if (value.Length >= 2)
                {
                    _model = value;
                }

            }

        }
        public double DriveTime
        {
            get { return _driveTime; }
            set
            {
              
                if (value > 0)
                {
                    _driveTime = value;
                }

            }

        }
        public double DrivePath
        {
            get { return _driveTime; }
            set
            {

                if (value > 0)
                {
                    _drivePath = value;
                }

            }

        }

       

        public virtual double AverageSpeed()
        {
            return DrivePath / DriveTime;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"{FactoryName} {Model} " +
                $"{Color} {DrivePath} {DriveTime}");
        }
        public override string ToString()
        {
            return $"{FactoryName} {Model}";
        }
        public abstract void DefineNatureHarmness();




    }
}
