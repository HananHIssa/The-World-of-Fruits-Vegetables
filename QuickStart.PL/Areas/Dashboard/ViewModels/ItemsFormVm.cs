namespace QuickStart.PL.Areas.Dashboard.ViewModels
{
    public class ItemsFormVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool isDelete { get; set; }
        public IFormFile Image { get; set; }
        public string? ImageName { get; set; }
        public int? PortfolioId { get; set; }
        public IEnumerable<PortfolioFormVm>? portfolios { get; set; }
    }
}
