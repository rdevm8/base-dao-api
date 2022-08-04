namespace base_dao_api.Models.Interfaces
{
    public interface IEntity
    {
        Guid Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDttm { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateDttm { get; set; }
        public bool IsDeleted { get; set; }
    }
}
