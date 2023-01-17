using OnlineShopping.Classes;
using System.ComponentModel;

namespace OnlineShopping
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<WebUser> webUsers = new()
            {
                new WebUser
                {
                    Login_id = "2020",
                    Password = "2020", Id = "1", Address = "address",
                    Email = "gmail", Phone = "+99833", BillingAddress = "Tipa"
                }
            };

            List<Product> listItem = new()
            {
                new Product {Id = 1, Name = "Fanta", Supplier = "Coca-Cole company", Price = 19000},
                new Product {Id = 2, Name = "Sprite", Supplier = "Coca-Cole company", Price = 21000},
                new Product {Id = 3, Name = "Pepsi", Supplier = "Pepsico company", Price = 18500},
            };
            List<Order> orderList = new();

            List<Payment> paymentList = new();

            bool isActive = true;
            Console.WriteLine("-------- Welcome our online shopping market place --------");
            while (isActive)
            {
                Console.Clear();
                Console.Write("Login: ");
                string login = Console.ReadLine();
                Console.Write("Password: ");
                string pass = Console.ReadLine();

                WebUser? user = webUsers.Find(a => a.Login_id == login);

                if (user != null)
                {
                    if (user.Password == pass)
                    {
                        // true option
                        if(user.BillingAddress == null)
                        {
                            Console.Write("You have not biling address, please enter your biling address: ");
                            user.BillingAddress = Console.ReadLine();
                        }
                        else if (user.BillingAddress != null)
                        {
                            Console.Clear();
                            // product
                            Console.WriteLine("-------- welcome our product market ---------");
                            for (int i = 0; i < 3; i++)
                            {
                                foreach (PropertyDescriptor item in TypeDescriptor.GetProperties(listItem[i]))
                                {
                                    string name = item.Name;
                                    object value = item.GetValue(listItem[i]);
                                    Console.Write($"{name}: {value}, ");
                                }
                                Console.WriteLine();
                            }
                            Console.Write("choose option by id: ");
                            int k = Convert.ToInt32(Console.ReadLine());
                            Console.Write("How many item: ");
                            int itemNumbers = Convert.ToInt32(Console.ReadLine());
                            
                            var order = new Order()
                            {
                                Id = k,
                                Ordered = DateTime.Now,
                                Shipped = DateTime.Now.AddDays(3).AddHours(5).AddMinutes(14),
                                ShipTo = user.Address,
                                TotalPrice = listItem[k - 1].Price * itemNumbers,
                            };
                            orderList.Add(order);
                            Console.WriteLine("Your order: ");
                            foreach (PropertyDescriptor item in TypeDescriptor.GetProperties(order))
                            {
                                string name = item.Name;
                                object value = item.GetValue(order);
                                Console.WriteLine($"{name}: {value}");
                            }
                            Console.Write("Press enter to confirm to pay by your billing card: ");
                            
                            Random r = new Random();

                            Console.ReadKey();
                            
                            var payment = new Payment()
                            {
                                Id = r.Next(10000, 1000000),
                                PaidDate = DateTime.Now,
                                TotalSum = order.TotalPrice,
                                Details = listItem[k-1].Name
                            };

                            Console.Write("Successfully paid, just enter to see payment details...");
                            Console.ReadKey();

                            foreach (PropertyDescriptor item in TypeDescriptor.GetProperties(payment))
                            {
                                string name = item.Name;
                                object value = item.GetValue(payment);
                                Console.WriteLine($"{name}: {value}");
                            }
                            Console.WriteLine("Thank you using our service\nPress enter to exit...");
                            Console.ReadKey();
                            isActive = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("error password");
                    }
                }
                else
                {
                    Console.WriteLine("You have not account, please fill the form: ");
                    Console.Write("Address: ");
                    string address = Console.ReadLine();
                    Console.Write("Phone: +(+998) ");
                    string number = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Create a login: ");
                    string login_id = Console.ReadLine();
                    Console.Write("Create a password: ");
                    string password = Console.ReadLine();
                    Console.Write("Please enter your billing adress: ");
                    string billingAddress = Console.ReadLine();
                    var newUser = new WebUser
                    {
                        Address = address,
                        Phone = number,
                        Email = email,
                        Login_id = login_id,
                        Password = password,
                        BillingAddress = billingAddress
                    };
                    webUsers.Add(newUser);
                    Console.WriteLine("Successfully registered... bro :0\a");
                    Console.ReadKey();
                    Console.Clear();
                }


            }
        }
    }
}