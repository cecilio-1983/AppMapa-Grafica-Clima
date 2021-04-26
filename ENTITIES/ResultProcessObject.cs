namespace ENTITIES
{
    public class ResultProcessObject<T>
    {
        public ResultProcessObject()
        {
            Success = true;
        }
        public T Entity { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
