using System.Net.Http.Headers;

namespace staticDem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company com1 = new Company("ООО Газпром", "197229, город Санкт-Петербург, Лахтинский пр-кт, д. 2 к. 3 стр. 1",
                1027700070518, 7736050003, TypeOfCompany.StateOwned);
            Company com2 = new Company("СБЕРБАНК РОССИИ", "117312, город Москва, ул Вавилова, д. 19 ",
                1027700132195, 7707083893, TypeOfCompany.Private);
            Company com3 = new Company("ЯНДЕКС", "119021, город Москва, ул Льва Толстого, д. 16",
                1027700229193, 7736207543, TypeOfCompany.StateOwned);
            Company com4 = new Company();
            Company com5 = new Company();

            //Console.WriteLine($"количество зарегестрированных компаний: {Company.countOfCompanies}");

            //Console.WriteLine($"количество частных компаний: {Company.countOfPrivateCompanies}\n" +
            //    $"количество государственных компаний: {Company.countOfStateOwnedCompanies}");

            Console.WriteLine(com3);
            com3.SetCapital(16_605_000M);
            com3.Capitalization(14);




        }
    }
}