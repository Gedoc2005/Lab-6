using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solida_Volymer
{
    class CircularCone : Solid
    {
        public override double BaseArea
        {
            get { return RadiusSquared * Math.PI; }
        }

        public override double SurfaceArea
        {
            get { return Math.PI * Radius * (Math.Sqrt(RadiusSquared + HeightSquared) + Radius); }
        }

        public override double Volume
        {
            get { return 1/3 *Math.PI * RadiusSquared * Height ; }
        }

        public CircularCone(double radius, double height)
            : base(radius, height)
        {
        }
    }
}
