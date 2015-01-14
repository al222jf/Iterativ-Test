using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testkod
{
    class GetPoints
    {
        private int _quantityOfPoints;
        private int[] _pointsArray;


        public GetPoints()
        {

        }

        public int[] PointsArray 
        {
            get { return _pointsArray; }
            set
            {
                _pointsArray = value;
            }
        }

        public GetPoints(int numberOfPoints)
        {
            GetQuantity = numberOfPoints;

        }

        public int GetQuantity
        {
            get { return _quantityOfPoints; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("FEL! Måste vara minst en domare!");
                }

                _quantityOfPoints = value;
            }
        }



        public void SavePoints(int points)
        {

            if (points < 1)
            {
                throw new ArgumentException("FEL! Poängen måste vara mer än noll");
            }
            _pointsArray = new int[_quantityOfPoints];
            if (_pointsArray.Length > 0)
            {
                for (int i = 0; i < _quantityOfPoints; i++)
                {
                    _pointsArray[i] = 0;
                }
            }
        }
       
    }
}
