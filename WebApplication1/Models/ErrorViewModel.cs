
namespace MyApp.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }   // Existing property
        public string? RequestName { get; set; } // Existing property
        public string? RequestPrice { get; set; } // Existing property


        // Add the missing 'Id' property here
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Price { get; set; }


        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public bool ShowRequestName => !string.IsNullOrEmpty(RequestName);
        public bool ShowRequestprice => !string.IsNullOrEmpty(RequestPrice);


    }
}


