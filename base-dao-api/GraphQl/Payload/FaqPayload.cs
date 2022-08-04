namespace base_dao_api.GraphQl.Payload
{
    public class FaqPayload
    {
        public string Question { get; set; } = String.Empty;

        public string Answer { get; set; } = String.Empty;

        public int Order { get; set; } = 0;
    }
}
