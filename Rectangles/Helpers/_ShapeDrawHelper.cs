namespace Rectangles.Helpers
{
    public abstract class ShapeDrawHelper<T> where T : struct 
    {
        public abstract void Draw(T shape);

        public abstract T? Find(Point location, Size size);

        public abstract bool Add(Point location, Size size);

        public abstract bool Remove(Point location, Size size);

        public abstract bool Clear();
    }
}
