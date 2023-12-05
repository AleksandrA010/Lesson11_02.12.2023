using Lub_14;
using System.Xml.Linq;
using System;

namespace Lub_13
{
    [BuildClassAtribute("Alexander", "BuildOrganization")]
    internal class Build
    {
        private int _numberBuild;       //Номер здания.
        private int _numberApartments;  //Количество квартир.
        private int _numberEntrances;   //Количество подъездов.
        private double _height;         //Высота.
        private int _numberFloors;      //Количество этажей.
        public int NumberBuild { get { return _numberBuild; } }
        public int NumberApartments { get { return _numberApartments; } }
        public int NumberEntrances { get { return _numberEntrances; } }
        public double Height { get { return _height; } }
        public int NumberFloors { get { return _numberFloors; } }
        public Build(int numberBuild, int numberFloors, int numberEntrances)
        {
            _numberBuild = numberBuild;
            _height = numberFloors * 3;
            _numberEntrances = numberEntrances;
            _numberFloors = numberFloors;
            _numberApartments = 2 * numberFloors * numberEntrances;
        }
    }
}
