namespace QuickStart.PL.Areas.Dashboard.ViewModels
{
    public class ServicesFormVm
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
        public string? ImageName { get; set; }
    }
}
