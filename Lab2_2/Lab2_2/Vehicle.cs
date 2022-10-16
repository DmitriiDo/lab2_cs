using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    public struct Vector3
    {
        public float x, y, z;
        public Vector3()
        {
            x = 0; y = 0; z = 0; 
        }
        public Vector3(float _x, float _y, float _z)
        {
            x = _x; y = _y; z = _z;
        }

        public override string ToString()
        {
            return $"({x},{y},{z})";
        }
    }
    // You can`t create an instance of "some" vehicle
    // It has to be something concrete
    public abstract class Vehicle
    {
        public Vector3 Position;
        public Vector3 Velocity;
        public int ProductionYear;

        public override string ToString()
        {
            return $"This is basic vehicle:\n" +
                   $"Position: {Position}\n" +
                   $"Velocity: {Velocity}\n" +
                   $"Production year : {ProductionYear}\n";
        }
    }

    public class Car : Vehicle
    {
        public int PassengersCount;
        public override string ToString()
        {
            return $"This is car:\n" +
                   $"Position: {Position}\n" +
                   $"Velocity: {Velocity}\n" +
                   $"Production year : {ProductionYear}\n" +
                   $"Passengers count : {PassengersCount}"; ;
        }
    }
    public class Plane : Vehicle
    {
        public float Height { get => Position.z; }
        public int PassengersCount;

        public override string ToString()
        {
            return $"This is plane:\n" +
                   $"Position: {Position}\n" +
                   $"Velocity: {Velocity}\n" +
                   $"Production year : {ProductionYear}\n" +
                   $"Height : {Height}\n" +
                   $"Passengers count : {PassengersCount}";
        }
    }

    public class Ship : Vehicle
    {
        public int PassengersCount;
        public string HomePort = string.Empty;

        public override string ToString()
        {
            return $"This is ship:\n" +
                   $"Position: {Position}\n" +
                   $"Velocity: {Velocity}\n" +
                   $"Production year : {ProductionYear}\n" +
                   $"Passengers count : {PassengersCount}\n" +
                   $"Home port : {HomePort}";
        }
    }
}
