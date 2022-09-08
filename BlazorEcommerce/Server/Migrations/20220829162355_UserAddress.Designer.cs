﻿// <auto-generated />
using System;
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220829162355_UserAddress")]
    partial class UserAddress
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorEcommerce.Shared.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.CartItem", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ProductId", "ProductTypeId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Книги",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Фильмы",
                            Url = "movies"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Видеоигры",
                            Url = "video-games"
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.OrderItem", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "ProductId", "ProductTypeId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Научно-популярная книга американского программиста Чарльза Петцольда, в которой рассказывается, как персональные компьютеры работают на аппаратном и программном уровне.",
                            Featured = true,
                            ImageUrl = "https://libroroom.ru/upload/iblock/833/18804.png",
                            Title = "Код. Тайный язык информатики"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Эта книга посвящена хорошему программированию. Она полна реальных примеров кода. Мы будем рассматривать код с различных направлений: сверху вниз, снизу вверх и даже изнутри. Прочитав книгу, вы узнаете много нового о коде. Более того, вы научитесь отличать хороший код от плохого. Вы узнаете, как писать хороший код и как преобразовать плохой код в хороший.",
                            Featured = false,
                            ImageUrl = "https://cdn1.ozone.ru/multimedia/wc1000/1023228489.jpg",
                            Title = "Чистый код. Создание, анализ и рефакторинг"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Паттерны проектирования остаются важным инструментом в арсенале разработчика, поскольку они опираются на фундаментальные принципы проектирования. Тем не менее, появление новых конструкций в современных языках программирования делает одни паттерны более важными, а значимость других сводит к минимуму.",
                            Featured = false,
                            ImageUrl = "https://cdn1.ozone.ru/multimedia/wc1000/1012077651.jpg",
                            Title = "Паттерны проектирования на платформе .NET"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Жизнь Томаса Андерсона разделена на две части: днём он — самый обычный офисный работник, получающий нагоняи от начальства, а ночью превращается в хакера по имени Нео, и нет места в сети, куда он бы не смог проникнуть. Но однажды всё меняется. Томас узнаёт ужасающую правду о реальности.",
                            Featured = true,
                            ImageUrl = "https://avatars.mds.yandex.net/get-kinopoisk-image/4486454/e1b83fc5-6073-4b16-8d1a-34083ee817ff/600x900",
                            Title = "Матрица"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "В ближайшем будущем разнообразные технологии участвуют во всех аспектах человеческой жизни. Но в этом технологичном мире Грей — один из немногих людей, кто любит работать руками. Он восстанавливает и чинит старые автомобили. Однажды, возвращаясь от клиента, Грей с женой попадают в аварию, а после — в руки банды отморозков, в результате чего женщина погибает, а Грей оказывается парализованным ниже шеи. Тот самый богатый клиент предлагает несчастному поставить экспериментальный имплант Stem, который может полностью восстановить подвижность.",
                            Featured = false,
                            ImageUrl = "https://www.megacritic.ru/media/reviews/photos/original/ef/a0/f3/1009784-50-1540074712.jpg",
                            Title = "Апгрейд"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Негодяи, подонки, вконец обнаглевшие и распоясавшиеся преступники и бандитские группировки всё равно не желают сдавать свои упрочившие позиции, опасаясь лишь одного - встречи с легендарным Судьёй Дреддом, пересажавшим или расстрелявшим не одну сотню насильников, террористов и жадных до человеческих страданий маньяков. В то время, как беспорядки и бесчинства бушуют на улицах города, Дредд спешит вернуть порядок, Закон и тишину, которым, кажется, уже никогда не обрести свою былую полноту, мощь и силу...",
                            Featured = false,
                            ImageUrl = "https://www.megacritic.ru/media/reviews/photos/original/f1/f9/ef/_kinopoisk.ru-dredd-3d-1942523-1344945818.jpg",
                            Title = "Судья Дредд"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "Артур Морган и другие подручные Датча ван дер Линде вынуждены пуститься в бега. Их банде предстоит участвовать в кражах, грабежах и перестрелках в самом сердце Америки. За ними по пятам идут федеральные агенты и лучшие в стране охотники за головами, а саму банду разрывают внутренние противоречия. Артуру предстоит выбрать, что для него важнее: его собственные идеалы или же верность людям, которые его взрастили.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/ru/0/03/Red_Dead_Redemption_2_coverart.jpg",
                            Title = "Red Dead Redemption 2"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Cyberpunk 2077 — приключенческая ролевая игра с открытым миром, рассказывающая о киберпанке-наёмнике Ви и борьбе за жизнь в мегаполисе Найт-Сити. Мрачное будущее стало ещё более впечатляющим в улучшенной версии, в которую вошли новые дополнительные материалы. Создайте персонажа, выберите стиль игры и начните свой путь к высшей лиге, выполняя заказы, улучшая репутацию и оттачивая навыки. Ваши поступки влияют на происходящее и на весь город. В нём рождаются легенды. Какую сложат о вас?",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/ru/b/bb/%D0%9E%D0%B1%D0%BB%D0%BE%D0%B6%D0%BA%D0%B0_%D0%BA%D0%BE%D0%BC%D0%BF%D1%8C%D1%8E%D1%82%D0%B5%D1%80%D0%BD%D0%BE%D0%B9_%D0%B8%D0%B3%D1%80%D1%8B_Cyberpunk_2077.jpg",
                            Title = "Cyberpunk 2077"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "Таинственное событие, известное как Death Stranding, в будущем открыло дверь между миром живых и миром мертвых. Как результат, уродливые потусторонние твари отправились бродить по падшему миру, в котором почти не осталось людей. Действуя от лица Сэма Бриджеса и объединяя последних выживших на территории Америки, вам предстоит возродить надежду человечества. Удастся ли вам шаг за шагом воссоединить разрушенный мир?",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/ru/e/ee/Death_Stranding_Poster.jpg",
                            Title = "Death Stranding"
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "По умолчанию"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Мягкая обложка"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Цифровая книга"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Аудиокнига"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Онлайн показ"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Blu-ray диск"
                        },
                        new
                        {
                            Id = 7,
                            Name = "VHS кассета"
                        },
                        new
                        {
                            Id = 8,
                            Name = "ПК версия"
                        },
                        new
                        {
                            Id = 9,
                            Name = "PlayStation"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Xbox"
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "ProductTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductVariants");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 2,
                            OriginalPrice = 2350m,
                            Price = 1630m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 3,
                            OriginalPrice = 0m,
                            Price = 900m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 4,
                            OriginalPrice = 2600m,
                            Price = 1800m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 2,
                            OriginalPrice = 1130m,
                            Price = 780m
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 2,
                            OriginalPrice = 0m,
                            Price = 630m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 5,
                            OriginalPrice = 0m,
                            Price = 470m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 6,
                            OriginalPrice = 0m,
                            Price = 920m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 7,
                            OriginalPrice = 0m,
                            Price = 300m
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 5,
                            OriginalPrice = 0m,
                            Price = 740m
                        },
                        new
                        {
                            ProductId = 6,
                            ProductTypeId = 5,
                            OriginalPrice = 0m,
                            Price = 950m
                        },
                        new
                        {
                            ProductId = 7,
                            ProductTypeId = 8,
                            OriginalPrice = 2600m,
                            Price = 2300m
                        },
                        new
                        {
                            ProductId = 7,
                            ProductTypeId = 9,
                            OriginalPrice = 0m,
                            Price = 4500m
                        },
                        new
                        {
                            ProductId = 7,
                            ProductTypeId = 10,
                            OriginalPrice = 4500m,
                            Price = 3600m
                        },
                        new
                        {
                            ProductId = 8,
                            ProductTypeId = 8,
                            OriginalPrice = 2450m,
                            Price = 1200m
                        },
                        new
                        {
                            ProductId = 9,
                            ProductTypeId = 8,
                            OriginalPrice = 0m,
                            Price = 1750m
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Address", b =>
                {
                    b.HasOne("BlazorEcommerce.Shared.User", null)
                        .WithOne("Address")
                        .HasForeignKey("BlazorEcommerce.Shared.Address", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.OrderItem", b =>
                {
                    b.HasOne("BlazorEcommerce.Shared.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorEcommerce.Shared.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorEcommerce.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.HasOne("BlazorEcommerce.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.ProductVariant", b =>
                {
                    b.HasOne("BlazorEcommerce.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorEcommerce.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.User", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}