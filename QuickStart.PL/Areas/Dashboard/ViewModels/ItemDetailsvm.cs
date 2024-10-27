namespace QuickStart.PL.Areas.Dashboard.ViewModels
{
    public class ItemDetailsvm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool isDelete { get; set; }
        public DateTime Data { get; set; }
        public string ImageName { get; set; }
        public IFormFile image { get; set; }
       
    }

}
