using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticDem
{
    enum TypeOfCompany { Private, StateOwned }

    internal class Company
    {
        string _title; //наименование компании
        string _addres; //юридический адрес
        ulong _ogrn;     //ОГРН
        ulong _inn;      //ИНН
        decimal _capital;   //уставной капитал
        public static int countOfCompanies = 0; //статическое поле - количество объектов класса
        public static int countOfPrivateCompanies = 0;
        public static int countOfStateOwnedCompanies = 0;

        public TypeOfCompany Type { get; set; }
        public string Title
        {
            get => _title;
            set
            {
                if (value =="")
                {
                    Console.WriteLine("название организации не может быть пустым. введите имя");
                    _title = Console.ReadLine();
                }
                else _title = value;            
            }
        }
        public string Addres
        {
            get => _addres;
            set
            {
                if (value =="")
                {
                    Console.WriteLine("Адрес организации не может быть пустым. введите адрес");
                    _addres = Console.ReadLine();
                }
                else _addres = value;
            }
        }
        public ulong Ogrn
        {
            get => _ogrn;
            set
            {
                if (value > 99999_99999_99 && value < 99999_99999_999)
                    _ogrn = value;
                else
                {
                    Console.WriteLine("ОГРН должен содержать 13 цифр");
                    _ogrn = Convert.ToUInt64(Console.ReadLine());
                }
            }
        }
        public ulong Inn
        {
            get => _inn;
            set
            {
                if (value > 99999_9999 && value < 99999_99999_9)
                    _inn = value;
                else
                {
                    Console.WriteLine("ИНН должен содержать 10 цифр");
                    _inn = Convert.ToUInt64(Console.ReadLine());
                }
            }
        }

        public Company(string title, string addres, ulong ogrn, ulong inn, TypeOfCompany type)
        {
            Title=title;
            Addres=addres;
            Ogrn=ogrn;
            Inn=inn;
            Type = type;
            _capital=Decimal.Zero;

            if(type == TypeOfCompany.Private) countOfPrivateCompanies++;
            else countOfStateOwnedCompanies++;

            countOfCompanies++;
        }

        public Company() 
        {
            countOfPrivateCompanies++;
            countOfCompanies++;
        }

        public override string ToString()
        {
            return $"{Title}\n" +
                $"юридические адрес: {Addres}\n" +
                $"ОКПО: {Ogrn}\n" +
                $"ИНН: {Inn}\n" +
                $"Тип компании: {(Type==TypeOfCompany.StateOwned ? "государственная" : "частная")}\n";
        }

        public void SetCapital(decimal summ)
        {
            _capital = summ;
            Console.WriteLine("установлена сумма уставного капитала: "+_capital);
        }
        public void Capitalization (int persent)
        {
            _capital = _capital + _capital*persent/100;
            Console.WriteLine($"после капитализации на {persent}% уставной капитал составил {_capital}");
        }


        /*
         *метод создания уставного капистала - принимает decimal параметр - начальную сумму уставного капитала
         *увеличивает поле _capinal на значение параметра. выводит сообщение о утановлении начального капитала
         *
         *
         *метод капитализации - в качестве параметра - процент капитализации
         *увеличивает сумму капитала на данный процент
         *\выводит сообщение о капитализации на % и итоговую сумму капитала
         *
         *
         *переопределить ToString() для вывода информации по объекту с учетом названия, адресса, ОГРН ИНН и типа
         */


    }
}
