using System.ComponentModel.DataAnnotations;

namespace base_dao_api.GraphQl.Payloads
{
    public class FaqPayload
    {
        [Required]
        [StringLength(250, MinimumLength =1)]
        public string Question { get; set; } = String.Empty;
        [Required]
        [StringLength(250, MinimumLength = 1)]
        public string Answer { get; set; } = String.Empty;
        [Required]
        [Range(1,9999)]
        public int Order { get; set; } = 0;
    }
}
