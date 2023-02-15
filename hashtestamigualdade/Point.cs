namespace Course.Entities {

    struct Point { //Struct é tipo valor

        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y) : this() {
            x = x;
            y = y;
        }
    }
} 