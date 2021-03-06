// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkAPI.Models;

namespace ParkFinder.Solution.Migrations
{
    [DbContext(typeof(ParkAPIContext))]
    [Migration("20210122210845_ChangeDBContextNameToAPI")]
    partial class ChangeDBContextNameToAPI
    {
        protected void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParkFinder.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Region");

                    b.Property<string>("State");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            City = "CraterLake",
                            Country = "USA",
                            Region = "Southern Oregon",
                            State = "OR"
                        },
                        new
                        {
                            LocationId = 2,
                            City = "Kimberly",
                            Country = "USA",
                            Region = "Eastern Oregon",
                            State = "OR"
                        },
                        new
                        {
                            LocationId = 3,
                            City = "Cave Junction",
                            Country = "USA",
                            Region = "Southern Oregon",
                            State = "OR"
                        },
                        new
                        {
                            LocationId = 4,
                            City = "Marblemount",
                            Country = "USA",
                            Region = "Northern WA",
                            State = "WA"
                        },
                        new
                        {
                            LocationId = 5,
                            City = "Port Angeles",
                            Country = "USA",
                            Region = "Western WA",
                            State = "WA"
                        },
                        new
                        {
                            LocationId = 6,
                            City = "Friday Harbor",
                            Country = "USA",
                            Region = "NW WA",
                            State = "WA"
                        });
                });

            modelBuilder.Entity("ParkFinder.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alerts");

                    b.Property<string>("BasicInfo");

                    b.Property<string>("Directions");

                    b.Property<string>("Fees");

                    b.Property<bool>("HasHikingTrails");

                    b.Property<bool>("HasVisitorCenter");

                    b.Property<bool>("InternetAccess");

                    b.Property<bool>("IsCurrentlyOpen");

                    b.Property<int>("LocationId");

                    b.Property<string>("ParkAddress");

                    b.Property<string>("ParkName");

                    b.Property<string>("RequiredPasses");

                    b.Property<string>("TypeOfPark");

                    b.HasKey("ParkId");

                    b.HasIndex("LocationId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Alerts = "Lots of snow! Chains required.",
                            BasicInfo = "Here's some history, geology, local knowledge",
                            Directions = "TBD",
                            Fees = "TBD",
                            HasHikingTrails = true,
                            HasVisitorCenter = true,
                            InternetAccess = false,
                            IsCurrentlyOpen = true,
                            LocationId = 1,
                            ParkAddress = "TBD",
                            ParkName = "Crater Lake",
                            RequiredPasses = "Yes, day passes and annual passes available.",
                            TypeOfPark = "National Park"
                        },
                        new
                        {
                            ParkId = 2,
                            Alerts = "Icy conditions. Drive with caution.",
                            BasicInfo = "Here's some history, geology, local knowledge",
                            Directions = "TBD",
                            Fees = "TBD",
                            HasHikingTrails = true,
                            HasVisitorCenter = true,
                            InternetAccess = false,
                            IsCurrentlyOpen = true,
                            LocationId = 2,
                            ParkAddress = "TBD",
                            ParkName = "John Day Fossil Beds",
                            RequiredPasses = "Yes, day passes and annual passes available.",
                            TypeOfPark = "National Monument"
                        },
                        new
                        {
                            ParkId = 3,
                            Alerts = "Landslide on road to OR caves visitor center.",
                            BasicInfo = "Here's some history, geology, local knowledge",
                            Directions = "TBD",
                            Fees = "TBD",
                            HasHikingTrails = true,
                            HasVisitorCenter = true,
                            InternetAccess = false,
                            IsCurrentlyOpen = true,
                            LocationId = 3,
                            ParkAddress = "TBD",
                            ParkName = "Oregon Caves",
                            RequiredPasses = "Yes, day passes and annual passes available.",
                            TypeOfPark = "National Monument & Preserve"
                        },
                        new
                        {
                            ParkId = 4,
                            Alerts = "CLosed for the season.",
                            BasicInfo = "Here's some history, geology, local knowledge",
                            Directions = "TBD",
                            Fees = "TBD",
                            HasHikingTrails = true,
                            HasVisitorCenter = true,
                            InternetAccess = false,
                            IsCurrentlyOpen = true,
                            LocationId = 4,
                            ParkAddress = "TBD",
                            ParkName = "North Cascades",
                            RequiredPasses = "Yes, day passes and annual passes available.",
                            TypeOfPark = "National Monument & Preserve"
                        },
                        new
                        {
                            ParkId = 5,
                            Alerts = "High tides. See X tide chart for more info.",
                            BasicInfo = "Here's some history, geology, local knowledge",
                            Directions = "TBD",
                            Fees = "TBD",
                            HasHikingTrails = true,
                            HasVisitorCenter = false,
                            InternetAccess = false,
                            IsCurrentlyOpen = true,
                            LocationId = 5,
                            ParkAddress = "TBD",
                            ParkName = "Olympic",
                            RequiredPasses = "Yes, day passes and annual passes available.",
                            TypeOfPark = "National Park"
                        },
                        new
                        {
                            ParkId = 6,
                            Alerts = "Ferry service delay on all afternoon boats 1.22.21. See WA State Ferries site for more info.",
                            BasicInfo = "Here's some history, geology, local knowledge",
                            Directions = "TBD",
                            Fees = "TBD",
                            HasHikingTrails = true,
                            HasVisitorCenter = true,
                            InternetAccess = false,
                            IsCurrentlyOpen = true,
                            LocationId = 6,
                            ParkAddress = "TBD",
                            ParkName = "San Juan Island",
                            RequiredPasses = "None required.",
                            TypeOfPark = "National Monument & Preserve"
                        });
                });

            modelBuilder.Entity("ParkFinder.Models.Park", b =>
                {
                    b.HasOne("ParkFinder.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
