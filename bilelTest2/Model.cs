namespace bilelTest2;

public class Model
{
    public ReleaseStatusSection[] releaseStatusSection { get; set; } 

public class ReleaseStatusSection
{
    public CarrierStatus carrierStatus { get; set; }
    public CustomStatus customStatus { get; set; }
}

public class CarrierStatus
{
    public string status { get; set; }
    public string date { get; set; }
}

public class CustomStatus
{
    public string status { get; set; }
    public string date { get; set; }
}


}