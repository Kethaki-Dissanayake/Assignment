using Assignment.Models;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;


namespace Assignment.Data
{
    public class AppDbIntializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Person 
                if (!context.Persons.Any())
                {
                    context.Persons.AddRange(new List<Person>()
                    {
                        new Person()
                        {
                            
                            ProfilePicture = "https://static.businessinsider.com/image/4cd19c7749e2ae0d7c030000-400/image.jpg",
                            FirstName = "John",
                            LastName = "Peter",
                            SSN = 123,
                            DOB = DateTime.Now.AddYears(-50)
                            

                        },

                        new Person()
                        {   
                            
                            ProfilePicture = "https://clipground.com/images/famous-people-png-1.png",
                            FirstName = "Barak",
                            LastName = "Obama",
                            SSN = 234,
                            DOB= DateTime.Now.AddYears(-60)
                            
                        },

                        new Person()
                        {
                            
                            ProfilePicture = "https://cdn.acidcow.com/pics/20140423/popular_people_instagram_32.jpg",
                            FirstName = "Steve",
                            LastName = "Jobs",
                            SSN = 345,
                            DOB= DateTime.Now.AddYears(-70)

                            

                        },

                        new Person()
                        {
                            
                            ProfilePicture = "https://1.bp.blogspot.com/-xS72NSIfR8s/YFu3pfutPbI/AAAAAAAACUk/fKjAQMXfs-s476SEcIrQKhN0bHV18XA2gCNcBGAsYHQ/s714/Most-popular-person-in-the-world-bill-gates.jpeg",
                            FirstName = "Tom",
                            LastName = "Jerry",
                            SSN = 456,
                            DOB= DateTime.Now.AddYears(-40)
                            

                        },

                        new Person()
                        {
                            
                            ProfilePicture = "http://4.bp.blogspot.com/-hfzvuEo5k9g/UBM0WnOmE4I/AAAAAAAAAV0/t5DiGl5el1U/s1600/bill-gates%5Bwww.freeallnewgames.blogspot.com%5D.jpg",
                            FirstName = "Albert",
                            LastName = "Thomas",
                            SSN = 678,
                            DOB= DateTime.Now.AddYears(-90)
                            
                        }
                                                    

                    });
                    context.SaveChanges();
                }

                //Email
                if(!context.Emails.Any())
                {
                    context.Emails.AddRange(new List<Email>()
                    {
                        new Email()
                        {
                            
                            EmailAddress = "john@gmail.com",
                            PersonId= 2
                        },
                        new Email()
                        {
                            
                            EmailAddress = "barak@gmail.com",
                            PersonId= 3
                        },
                        new Email()
                        {
                            
                            EmailAddress = "steve@gmail.com",
                            PersonId= 4
                        },
                        new Email()
                        {   
                            EmailAddress = "tom@gmail.com",
                            PersonId= 5
                        },
                        new Email()
                        {
                           
                            EmailAddress = "albert@gmail.com",
                            PersonId= 6
                        }


                    });
                    context.SaveChanges();

                }

                //AddressSqlException: The MERGE statement conflicted with the FOREIGN KEY constraint "FK_Emails_Persons_PersonId". The conflict occurred in database "addovation-demo", table "dbo.Persons", column 'PersonId'.

                if (!context.Addresses.Any())
                {
                    context.Addresses.AddRange(new List<Address>()
                    {
                        new Address()
                        {
                           HouseNo = "12",
                           Street = "Street1",
                           City = "City1",
                           District = "District1",
                           ZipCode = 100,
                           PersonId= 2
                        },
                        new Address()
                        {
                           HouseNo = "13",
                           Street = "Street2",
                           City = "City2",
                           District = "District2",
                           ZipCode = 200,
                           PersonId= 3
                        },
                        new Address()
                        {
                           HouseNo = "14",
                           Street = "Street3",
                           City = "City3",
                           District = "District3",
                           ZipCode = 300,
                           PersonId= 4
                        },
                        new Address()
                        {
                           HouseNo = "15",
                           Street = "Street4",
                           City = "City4",
                           District = "District4",
                           ZipCode = 400,
                           PersonId= 5
                        },
                        new Address()
                        {
                           HouseNo = "16",
                           Street = "Street5",
                           City = "City5",
                           District = "District5",
                           ZipCode = 500,
                           PersonId= 6
                        }


                    });
                         
                    context.SaveChanges();

                }

                //Phone
                if (!context.Phones.Any())
                {
                    context.Phones.AddRange(new List<Phone>()
                    {
                        new Phone()
                        {
                            Mobile = "1234567890",
                            FixedLine= "0112439806",
                            PersonId= 2
                            
                        },
                        new Phone()
                        {
                            Mobile = "23456780",
                            FixedLine= "011243967",
                            PersonId= 3

                        },
                        new Phone()
                        {
                            Mobile = "123450000",
                            FixedLine= "011240000",
                            PersonId= 4

                        },
                        new Phone()
                        {
                            Mobile = "1234564444",
                            FixedLine= "011244444",
                            PersonId= 5

                        },
                        new Phone()
                        {
                            Mobile = "1234555555",
                            FixedLine= "0112555555",
                            PersonId= 6

                        }



                    });
                    context.SaveChanges();

                }
            }
        }
    }
}
