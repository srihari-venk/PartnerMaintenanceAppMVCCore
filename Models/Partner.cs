
public class Partner
{
    public string Name { get; set; }
    public int ID { get; set; }
    public string Email { get; set; }
    public string QID { get; set; }
    public PartnerType PartnerType { get; set; }
    public string RequestStatus { get; set; }
}

public enum PartnerType
{
    Maintenance,
    Operations
}