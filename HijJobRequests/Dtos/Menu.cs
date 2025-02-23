namespace HijJobRequests.Dtos
{
    public class MenuDto
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public decimal Order { get; set; }
        public List<SubMenuDto> SubMenus { get; set; } = new();
    }

    public class SubMenuDto
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public decimal Order { get; set; }
        public List<PageDto> Pages { get; set; } = new();
    }

    public class PageDto
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public decimal Order { get; set; }
        public decimal Link { get; set; }
    }

}
