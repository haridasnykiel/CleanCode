namespace ObjectsAndDataStructures {
    public class BadPoint {
        public double x;
        public double y;
    }

    public interface IGoodPoint {
        double GetX();
        double GetY();

        void SetCartesian (double x, double y);

        double GetR();
        double GetTheta(); 

        void SetPolar (double r, double theta);
    }
}