namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; }

        public DataResult(bool success, string message, T data) : base(true, message)
        {
            Data = data;
        }

        public DataResult(bool success, T data) : base(true)
        {
            Data = data;
        }
    }
}