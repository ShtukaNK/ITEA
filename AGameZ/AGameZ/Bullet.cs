using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGameZ
{
    class Bullet
    {
        public string direction;
        public int speed = 20;
        PictureBox bullet = new PictureBox();
        Timer tm = new Timer();
        public int bulletLeft();
        public int bulletTop();
    }
}
