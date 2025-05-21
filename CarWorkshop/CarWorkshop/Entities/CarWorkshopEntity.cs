namespace CarWorkshop.Entities
{
    public class CarWorkshopEntity
    {

        // default -> for string, default is null.
        // ! -> (null-forgiving operator) tells the compiler trust me, it will be initialized properly later.

        // ABOUT
        // - Required for EntityFramework. It's the definition of primary key in the table.
        // - Has to be named exacly "Id".
        public int Id { get; set; } 
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public string Address { get; set; } = default!;
        public string? PhoneNumber { get; set; }

    }
}
