using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

[Table("TestTable")] // Ensure this matches the Supabase table name
public class TestTable : BaseModel
{
    [PrimaryKey("id")] // Ensure this matches your table's primary key
    public int Id { get; set; }

    [Column("name")] // Ensure the column names match exactly in Supabase
    public string Name { get; set; }

    [Column("value")]
    public int Value { get; set; }
}