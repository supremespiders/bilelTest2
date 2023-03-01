
using System.Text.Json.Serialization;
using bilelTest2;
using Newtonsoft.Json;

var model = new Model()
{
    releaseStatusSection = new[]
    {
        new Model.ReleaseStatusSection()
        {
            carrierStatus = new Model.CarrierStatus() { status = "s", date = "d" },
            customStatus = new Model.CustomStatus() { status = "as", date = "a" }
        }
    }
};
Console.WriteLine(JsonConvert.SerializeObject(model,Formatting.Indented));

Console.ReadLine();