using System.ComponentModel.DataAnnotations;

namespace LawnService.Models.DomainModels
{
    public class Store
    {
        [Key] public int StoreId { get; set; }

        public string Location { get; set; }
        public int ManagerId { get; set; }
        public int StaffReq { get; set; }
    }
}