using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overlap_of_rectangles {
    class Rectangle {
        //ID, широчина, височина и координатите на неговия горен ляв ъгъл (по хоризонтала и по вертикала
        private string id;
        private double width;
        private double height;
        private double x;
        private double y;

        public string ID{
            get{
                return id;
            }
            set{
                id = value;
            }
        }

        public double Width{
            get{
                return width;
            }
            set{
                width = value;
            }
        }

        public double Height {
            get {
                return height;
            }
            set {
                height = value;
            }
        }

        public double X {
            get {
                return x;
            }
            set {
                x = value;
            }
        }

        public double Y {
            get {
                return y;
            }
            set {
                y = value;
            }
        }

        public Rectangle(string id, double width, double height, double x, double y){
            this.id = id;
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
        }

        public bool ColisionCheck(Rectangle rectangle){
            for(int i = 0; i < 4; i++){
                double currentX = i % 2 == 0 ? this.x : this.x + width;
                double currentY = i % 2 == 0 ? this.y : this.y - height;
                if(rectangle.x <= currentX && rectangle.x + rectangle.width >= currentX && rectangle.y >= currentY && rectangle.y - rectangle.height <= currentY){
                    return true;
                }
            }
            return false;
        }
    }
}
