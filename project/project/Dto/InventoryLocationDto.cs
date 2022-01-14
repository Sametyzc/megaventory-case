
namespace project.Dto
{
    public class InventoryLocationDto
    {
        public class Create : GeneralCreateDto
        {
            public MvInventoryLocation mvInventoryLocation { get; set; }
        }
        public class MvInventoryLocation
        {
            public string InventoryLocationName { get; set; }
            public string InventoryLocationAbbreviation { get; set; }
            public string InventoryLocationAddress { get; set; }
        }
    }
}
