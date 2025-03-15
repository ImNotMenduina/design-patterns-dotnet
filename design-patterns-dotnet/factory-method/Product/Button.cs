namespace factory_method.Product
{
    public abstract class Button
    {
        public string? Backgorund { get; private set; }

        public string? Title { get; private set; }
        public abstract string Render();
        public abstract string onClick();
    }
}
