using LogisticsTrackingSoftware.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.Data.Data
{
    public class AppDbInitializer
    {

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                {
                    context.Database.EnsureCreated();

                    //Drivers
                    if (!context.Drivers.Any())
                    {
                        context.Drivers.AddRange(new List<Driver>()
                        {
                            new Driver()
                            {
                                FirstName = "Andre",
                                LastName =  "Thompson",
                                Email = "Dre@gmail.com",
                                PhoneNumber = "9855154269",
                                StreetAddress = "1234 KingLand Dr",
                                City = "Hammond",
                                State = "Louisiana",
                                ZipCode = "70434",
                                DateOfBirth = DateTime.Now,
                                ApplicationDate = DateTime.Now,
                                HireDate = DateTime.Now,
                                EmergencyContact =  "John Doe",
                                EmergencyContactPhone = "9855152394",
                                DriverNotes = "Driver does not like driving in mountains",
                                DriverPay = 0.25m

                            },

                            new Driver()
                            {
                                FirstName = "Kingston",
                                LastName =  "Robertson",
                                Email = "kingston@gmail.com",
                                PhoneNumber = "4692330452",
                                StreetAddress = "1234 Blackjack Oaks",
                                City = "Dallas",
                                State = "Texas",
                                ZipCode = "70434",
                                DateOfBirth = DateTime.Now,
                                ApplicationDate = DateTime.Now,
                                HireDate = DateTime.Now,
                                EmergencyContact =  "Lisa Doe",
                                EmergencyContactPhone = "9855152393",
                                DriverNotes = "Driver does not like driving in the west",
                                DriverPay = 0.25m
                                

                            },

                            new Driver()
                            {
                                FirstName = "Deshara",
                                LastName =  "Hall",
                                Email = "deshara@gmail.com",
                                PhoneNumber = "4692330269",
                                StreetAddress = "1234 Stoneborrk Ave",
                                City = "Prairieville",
                                State = "Louisiana",
                                ZipCode = "70469",
                                DateOfBirth = DateTime.Now,
                                ApplicationDate = DateTime.Now,
                                HireDate = DateTime.Now,
                                EmergencyContact =  "Henry Doe",
                                EmergencyContactPhone = "9855152393",
                                DriverNotes = "Driver does not like driving in the snow",
                                DriverPay = 0.27m

                            }

                        }) ;

                        context.SaveChanges();
                    }

                    //Trucks
                    if (!context.Trucks.Any())
                    {
                        context.Trucks.AddRange(new List<Truck>()
                        {
                            new Truck()
                            {
                                Year = 2016,
                                Make = "Freightliner",
                                Model = "Cascadia",
                                EquipmentNumber = 100,
                                Color = "White",
                                VinNumber = "3akjghdv3gsgv2740",
                                LicensePlateNumber = "P123455",
                                Description = "Purchased from select trucks"
                            },

                             new Truck()
                            {
                                Year = 2016,
                                Make = "Freightliner",
                                Model = "Cascadia",
                                EquipmentNumber = 101,
                                Color = "White",
                                VinNumber = "3akjghdv3gsgv2743",
                                LicensePlateNumber = "P123456",
                                Description = "Purchased from select trucks"

                            },

                            new Truck()
                            {
                                Year = 2016,
                                Make = "Peterbuilt",
                                Model = "T100",
                                EquipmentNumber = 102,
                                Color = "White",
                                VinNumber = "3akjghdv3gsgv2744",
                                LicensePlateNumber = "P123452",
                                Description = "Lease on truck"

                            }
                        });
                        context.SaveChanges();

                    }

                    //Trailers
                    if (!context.Trailers.Any())
                    {
                        context.Trailers.AddRange(new List<Trailer>()
                        {
                            new Trailer()
                            {
                                Year = 2012,
                                Make = "Utility",
                                TrailerType = TrailerType.Van,
                                EquipmentNumber = 7048,
                                Color = "White",
                                VinNumber = "3akjghdv3gsgv2752",
                                LicensePlateNumber = "P234567",
                                Description = "Air ride trailer with metal floor"

                            },

                            new Trailer()
                            {
                                Year = 2013,
                                Make = "Great Dane",
                                TrailerType = TrailerType.Van,
                                EquipmentNumber = 7047,
                                Color = "White",
                                VinNumber = "3akjghdv3gsgv2753",
                                LicensePlateNumber = "P234568",
                                Description = "Air ride trailer with metal floor"

                            },

                            new Trailer()
                            {
                                Year = 2007,
                                Make = "Benson",
                                TrailerType = TrailerType.Flatbed,
                                EquipmentNumber = 7049,
                                Color = "White",
                                VinNumber = "3akjghdv3gsgv2753",
                                LicensePlateNumber = "P234568",
                                Description = "Flatbed trailer leased from Hp Leasing metal floor"

                            },

                        });
                        context.SaveChanges();
                    }

                    //Brokers
                    if (!context.Brokers.Any())
                    {
                        context.AddRange(new List<Broker>()
                        {
                            new Broker()
                            {
                                CompanyName = "Landstar",
                                City = "Hammond",
                                State = "Louisiana",
                                ZipCode = "70438"
                                    
                            },

                            new Broker()
                            {
                                CompanyName = "TQL",
                                City = "Tylertown",
                                State = "Mississippi",
                                ZipCode = "70438"

                            },

                            new Broker()
                            {
                                CompanyName = "Axle Logistics",
                                City = "Hattiesburg",
                                State = "Mississippi",
                                ZipCode = "70438"
                            },

                            new Broker()
                            {
                                CompanyName = "Warner",
                                City = "Houston",
                                State = "Texas",
                                ZipCode = "70438"
                            },

                            new Broker()
                            {
                                CompanyName = "JB Hunt",
                                City = "Dallas",
                                State = "Texas",
                                ZipCode = "70438"
                            },

                            new Broker()
                            {
                                CompanyName = "Coyote Logistics",
                                City = "Tampa Bay",
                                State = "Florida",
                                ZipCode = "70439"

                            }

                        });
                        context.SaveChanges();
                    }

                    //Dispatchers
                    if (!context.Dispatchers.Any())
                    {
                        context.AddRange(new List<Dispatcher>()
                        {
                            new Dispatcher()
                            {
                                Name = "Good Energy World Wide",
                                DispatchFee = 0.10m
                            },

                            new Dispatcher()
                            {
                                Name = "Clarks Dispatching",
                                DispatchFee = 0.10m
                            }

                        });
                        context.SaveChanges();
                    }

                    //Loads
                    if (!context.Loads.Any())
                    {
                        context.AddRange(new List<Load>()
                        {
                            new Load()
                            {
                                LoadNumber =  "123456",
                                StartDate = DateTime.Now.AddDays(-3),
                                EndDate = DateTime.Now.AddDays(5),
                                LoadedMiles = 800,
                                UnloadedMiles = 50,
                                BobTailMiles = 0,
                                OtherMiles = 0,
                                LoadPay = 2500M,
                                CargoWeight = 36000,
                                CargoDescription = "Load of nuts and bolts",
                                BrokerId = 14,
                                DriverId = 5,
                                TruckId =  5,
                                TrailerId = 5,
                                DispatcherId = 3,                              
                            },

                            new Load()
                            {
                                LoadNumber =  "123457",
                                StartDate = DateTime.Now.AddDays(-1),
                                EndDate = DateTime.Now.AddDays(1),
                                LoadedMiles = 900,
                                UnloadedMiles = 60,
                                BobTailMiles = 0,
                                OtherMiles = 0,
                                LoadPay = 1800M,
                                CargoWeight = 33000,
                                CargoDescription = "Load of nuts and bolts",
                                BrokerId = 13,
                                DriverId = 5,
                                TruckId =  5,
                                TrailerId = 5,
                                DispatcherId = 3,
                            },

                            new Load()
                            {
                                LoadNumber =  "123458",
                                StartDate = DateTime.Now.AddDays(1),
                                EndDate = DateTime.Now.AddDays(1),
                                LoadedMiles = 900,
                                UnloadedMiles = 60,
                                BobTailMiles = 0,
                                OtherMiles = 0,
                                LoadPay = 1800M,
                                CargoWeight = 33000,
                                CargoDescription = "Load of nuts and bolts",
                                BrokerId = 13,
                                DriverId = 5,
                                TruckId =  5,
                                TrailerId = 5,
                                DispatcherId = 3,
                            },

                            new Load()
                            {
                                LoadNumber =  "123459",
                                StartDate = DateTime.Now.AddDays(2),
                                EndDate = DateTime.Now.AddDays(2),
                                LoadedMiles = 900,
                                UnloadedMiles = 60,
                                BobTailMiles = 0,
                                OtherMiles = 0,
                                LoadPay = 1800M,
                                CargoWeight = 33000,
                                CargoDescription = "Load of nuts and bolts",
                                BrokerId = 13,
                                DriverId = 5,
                                TruckId =  5,
                                TrailerId = 5,
                                DispatcherId = 3,
                            }

                        });
                        context.SaveChanges();

                    }





                }
            }
        }
    }
}
