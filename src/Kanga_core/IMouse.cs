namespace Kanga_core
{
    public interface IMouse
    {

        void Init();
        Mouse GetData();
        void OnClick(params object[] data);

    }
}