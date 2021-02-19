namespace ksis_lab1
{
    public interface ITextAnimationContextProvider
    {
        IAnimationProvider AnimationProvider { get; }
        void WriteLine(string data);
        string ReadLine();
        void StartAnimation();
        void StopAnimation();
    }
}