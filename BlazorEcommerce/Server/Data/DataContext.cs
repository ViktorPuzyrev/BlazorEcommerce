namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>()
               .HasKey(ci => new { ci.UserId, ci.ProductId, ci.ProductTypeId });

            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<OrderItem>()
                .HasKey(oi => new { oi.OrderId, oi.ProductId, oi.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                    new ProductType { Id = 1, Name = "По умолчанию" },
                    new ProductType { Id = 2, Name = "Мягкая обложка" },
                    new ProductType { Id = 3, Name = "Цифровая книга" },
                    new ProductType { Id = 4, Name = "Аудиокнига" },
                    new ProductType { Id = 5, Name = "Онлайн показ" },
                    new ProductType { Id = 6, Name = "Blu-ray диск" },
                    new ProductType { Id = 7, Name = "VHS кассета" },
                    new ProductType { Id = 8, Name = "ПК версия" },
                    new ProductType { Id = 9, Name = "PlayStation" },
                    new ProductType { Id = 10, Name = "Xbox" }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Книги",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Фильмы",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Видеоигры",
                    Url = "video-games"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Код. Тайный язык информатики",
                    Description = "Научно-популярная книга американского программиста Чарльза Петцольда, в которой рассказывается, как персональные компьютеры работают на аппаратном и программном уровне.",
                    ImageUrl = "https://libroroom.ru/upload/iblock/833/18804.png",
                    CategoryId = 1,
                    Featured = true
                },

                new Product
                {
                    Id = 2,
                    Title = "Чистый код. Создание, анализ и рефакторинг",
                    Description = "Эта книга посвящена хорошему программированию. Она полна реальных примеров кода. Мы будем рассматривать код с различных направлений: сверху вниз, снизу вверх и даже изнутри. Прочитав книгу, вы узнаете много нового о коде. Более того, вы научитесь отличать хороший код от плохого. Вы узнаете, как писать хороший код и как преобразовать плохой код в хороший.",
                    ImageUrl = "https://cdn1.ozone.ru/multimedia/wc1000/1023228489.jpg",
                    CategoryId = 1
                },

                new Product
                {
                    Id = 3,
                    Title = "Паттерны проектирования на платформе .NET",
                    Description = "Паттерны проектирования остаются важным инструментом в арсенале разработчика, поскольку они опираются на фундаментальные принципы проектирования. Тем не менее, появление новых конструкций в современных языках программирования делает одни паттерны более важными, а значимость других сводит к минимуму.",
                    ImageUrl = "https://cdn1.ozone.ru/multimedia/wc1000/1012077651.jpg",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 4,
                    Title = "Матрица",
                    Description = "Жизнь Томаса Андерсона разделена на две части: днём он — самый обычный офисный работник, получающий нагоняи от начальства, а ночью превращается в хакера по имени Нео, и нет места в сети, куда он бы не смог проникнуть. Но однажды всё меняется. Томас узнаёт ужасающую правду о реальности.",
                    ImageUrl = "https://avatars.mds.yandex.net/get-kinopoisk-image/4486454/e1b83fc5-6073-4b16-8d1a-34083ee817ff/600x900",
                    CategoryId = 2,
                    Featured = true
                },
                new Product
                {
                    Id = 5,
                    Title = "Апгрейд",
                    Description = "В ближайшем будущем разнообразные технологии участвуют во всех аспектах человеческой жизни. Но в этом технологичном мире Грей — один из немногих людей, кто любит работать руками. Он восстанавливает и чинит старые автомобили. Однажды, возвращаясь от клиента, Грей с женой попадают в аварию, а после — в руки банды отморозков, в результате чего женщина погибает, а Грей оказывается парализованным ниже шеи. Тот самый богатый клиент предлагает несчастному поставить экспериментальный имплант Stem, который может полностью восстановить подвижность.",
                    ImageUrl = "https://www.megacritic.ru/media/reviews/photos/original/ef/a0/f3/1009784-50-1540074712.jpg",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 6,
                    Title = "Судья Дредд",
                    Description = "Негодяи, подонки, вконец обнаглевшие и распоясавшиеся преступники и бандитские группировки всё равно не желают сдавать свои упрочившие позиции, опасаясь лишь одного - встречи с легендарным Судьёй Дреддом, пересажавшим или расстрелявшим не одну сотню насильников, террористов и жадных до человеческих страданий маньяков. В то время, как беспорядки и бесчинства бушуют на улицах города, Дредд спешит вернуть порядок, Закон и тишину, которым, кажется, уже никогда не обрести свою былую полноту, мощь и силу...",
                    ImageUrl = "https://www.megacritic.ru/media/reviews/photos/original/f1/f9/ef/_kinopoisk.ru-dredd-3d-1942523-1344945818.jpg",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 7,
                    Title = "Red Dead Redemption 2",
                    Description = "Артур Морган и другие подручные Датча ван дер Линде вынуждены пуститься в бега. Их банде предстоит участвовать в кражах, грабежах и перестрелках в самом сердце Америки. За ними по пятам идут федеральные агенты и лучшие в стране охотники за головами, а саму банду разрывают внутренние противоречия. Артуру предстоит выбрать, что для него важнее: его собственные идеалы или же верность людям, которые его взрастили.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/ru/0/03/Red_Dead_Redemption_2_coverart.jpg",
                    CategoryId = 3,
                    Featured = true
                },
                new Product
                {
                    Id = 8,
                    Title = "Cyberpunk 2077",
                    Description = "Cyberpunk 2077 — приключенческая ролевая игра с открытым миром, рассказывающая о киберпанке-наёмнике Ви и борьбе за жизнь в мегаполисе Найт-Сити. Мрачное будущее стало ещё более впечатляющим в улучшенной версии, в которую вошли новые дополнительные материалы. Создайте персонажа, выберите стиль игры и начните свой путь к высшей лиге, выполняя заказы, улучшая репутацию и оттачивая навыки. Ваши поступки влияют на происходящее и на весь город. В нём рождаются легенды. Какую сложат о вас?",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/ru/b/bb/%D0%9E%D0%B1%D0%BB%D0%BE%D0%B6%D0%BA%D0%B0_%D0%BA%D0%BE%D0%BC%D0%BF%D1%8C%D1%8E%D1%82%D0%B5%D1%80%D0%BD%D0%BE%D0%B9_%D0%B8%D0%B3%D1%80%D1%8B_Cyberpunk_2077.jpg",
                    CategoryId = 3
                },
                new Product
                {
                    Id = 9,
                    Title = "Death Stranding",
                    Description = "Таинственное событие, известное как Death Stranding, в будущем открыло дверь между миром живых и миром мертвых. Как результат, уродливые потусторонние твари отправились бродить по падшему миру, в котором почти не осталось людей. Действуя от лица Сэма Бриджеса и объединяя последних выживших на территории Америки, вам предстоит возродить надежду человечества. Удастся ли вам шаг за шагом воссоединить разрушенный мир?",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/ru/e/ee/Death_Stranding_Poster.jpg",
                    CategoryId = 3
                }
                );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 2,
                    Price = 1630m,
                    OriginalPrice = 2350m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 3,
                    Price = 900m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 4,
                    Price = 1800m,
                    OriginalPrice = 2600m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 2,
                    Price = 780m,
                    OriginalPrice = 1130m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 2,
                    Price = 630m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 5,
                    Price = 470m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 6,
                    Price = 920m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 7,
                    Price = 300m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 5,
                    Price = 740m,
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 5,
                    Price = 950m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 8,
                    Price = 2300m,
                    OriginalPrice = 2600m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 9,
                    Price = 4500m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 10,
                    Price = 3600m,
                    OriginalPrice = 4500m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    ProductTypeId = 8,
                    Price = 1200m,
                    OriginalPrice = 2450m,
                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 8,
                    Price = 1750m
                }
            );

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
