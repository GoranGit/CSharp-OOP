
namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Video:Multimedia
    {
        private int fps;
        public int FPS 
        {
            get
            {
                return this.fps;
            }
            private set 
            {
                ValidationData.LessThanZero(value, "fps");
                this.fps = value;
            }
        }
    }
}
