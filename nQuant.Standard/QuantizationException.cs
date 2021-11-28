namespace nQuant.Standard
{
    [System.Serializable]
    public class QuantizationException : System.ApplicationException
    {
        public QuantizationException(string message) : base(message) { }
    }
}
