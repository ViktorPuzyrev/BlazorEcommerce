namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Код. Тайный язык информатики",
                    Description = "Научно-популярная книга американского программиста Чарльза Петцольда, в которой рассказывается, как персональные компьютеры работают на аппаратном и программном уровне.",
                    ImageUrl = "https://libroroom.ru/upload/iblock/833/18804.png",
                    Price = 1630m
                },

                new Product
                {
                    Id = 2,
                    Title = "Чистый код. Создание, анализ и рефакторинг",
                    Description = "Эта книга посвящена хорошему программированию. Она полна реальных примеров кода. Мы будем рассматривать код с различных направлений: сверху вниз, снизу вверх и даже изнутри. Прочитав книгу, вы узнаете много нового о коде. Более того, вы научитесь отличать хороший код от плохого. Вы узнаете, как писать хороший код и как преобразовать плохой код в хороший.",
                    ImageUrl = "https://cdn1.ozone.ru/multimedia/wc1000/1023228489.jpg",
                    Price = 780m
                },

                new Product
                {
                    Id = 3,
                    Title = "Паттерны проектирования на платформе .NET",
                    Description = "Паттерны проектирования остаются важным инструментом в арсенале разработчика, поскольку они опираются на фундаментальные принципы проектирования. Тем не менее, появление новых конструкций в современных языках программирования делает одни паттерны более важными, а значимость других сводит к минимуму.",
                    ImageUrl = "https://cdn1.ozone.ru/multimedia/wc1000/1012077651.jpg",
                    Price = 630m
                }
                );
        }
        DbSet<Product> Products { get; set; }
    }
}
