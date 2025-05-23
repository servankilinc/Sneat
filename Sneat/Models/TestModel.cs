using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace Sneat.Models
{
    public class TestModel
    {
        [Key]
        public int Id { get; set; }
        public string? Avatar { get; set; }
        public string? Full_name { get; set; }
        public string? Post { get; set; }
        public string? Email { get; set; }
        public string? City { get; set; }
        public string? Start_date { get; set; }
        public string? Salary { get; set; }
        public string? Age { get; set; }
        public string? Experience { get; set; }
        public int Status { get; set; }


    }
    public static class TestModelManager
    {
        private static List<TestModel>? _list;
        public static List<TestModel> List 
        { 
            get {
                if( _list == null)
                {
                   _list = GenerateList(); 
                }
                return _list; } 
            set { _list = value; }
        }


        private static List<TestModel> GenerateList()
        {
            return new List<TestModel>
            {
                new TestModel
                {
                    Id =  1,
                    Avatar =  "10.png",
                    Full_name =  "Korrie O'Crevy",
                    Post =  "Nuclear Power Engineer",
                    Email =  "kocrevy0@thetimes.co.uk",
                    City =  "Krasnosilka",
                    Start_date =  "09/23/2021",
                    Salary =  "$23896.35",
                    Age =  "61",
                    Experience =  "1 Year",
                    Status = 2
                },
                new TestModel
                {
                    Id = 2,
                    Avatar = "1.png",
                    Full_name = "Bailie Coulman",
                    Post = "VP Quality Control",
                    Email = "bcoulman1@yolasite.com",
                    City = "Hinigaran",
                    Start_date = "05/20/2021",
                    Salary = "$13633.69",
                    Age = "63",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 3,
                    Avatar = "9.png",
                    Full_name = "Stella Ganderton",
                    Post = "Operator",
                    Email = "sganderton2@tuttocitta.it",
                    City = "Golcowa",
                    Start_date = "03/24/2021",
                    Salary = "$13076.28",
                    Age = "66",
                    Experience = "6 Years",
                    Status = 5
               },
                new TestModel
                {
                    Id = 4,
                    Avatar = "10.png",
                    Full_name = "Dorolice Crossman",
                    Post = "Cost Accountant",
                    Email = "dcrossman3@google.co.jp",
                    City = "Paquera",
                    Start_date = "12/03/2021",
                    Salary = "$12336.17",
                    Age = "22",
                    Experience = "2 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 5,
                    Avatar = "",
                    Full_name = "Harmonia Nisius",
                    Post = "Senior Cost Accountant",
                    Email = "hnisius4@gnu.org",
                    City = "Lucan",
                    Start_date = "08/25/2021",
                    Salary = "$10909.52",
                    Age = "33",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 6,
                    Avatar = "",
                    Full_name = "Genevra Honeywood",
                    Post = "Geologist",
                    Email = "ghoneywood5@narod.ru",
                    City = "Maofan",
                    Start_date = "06/01/2021",
                    Salary = "$17803.80",
                    Age = "61",
                    Experience = "1 Year",
                    Status = 1
               },
                new TestModel
                {
                    Id = 7,
                    Avatar = "",
                    Full_name = "Eileen Diehn",
                    Post = "Environmental Specialist",
                    Email = "ediehn6@163.com",
                    City = "Lampuyang",
                    Start_date = "10/15/2021",
                    Salary = "$18991.67",
                    Age = "59",
                    Experience = "9 Years",
                    Status = 3
               },
                new TestModel
                {
                    Id = 8,
                    Avatar = "9.png",
                    Full_name = "Richardo Aldren",
                    Post = "Senior Sales Associate",
                    Email = "raldren7@mtv.com",
                    City = "Skoghall",
                    Start_date = "11/05/2021",
                    Salary = "$19230.13",
                    Age = "55",
                    Experience = "5 Years",
                    Status = 3
               },
                new TestModel
                {
                    Id = 9,
                    Avatar = "2.png",
                    Full_name = "Allyson Moakler",
                    Post = "Safety Technician",
                    Email = "amoakler8@shareasale.com",
                    City = "Mogilany",
                    Start_date = "12/29/2021",
                    Salary = "$11677.32",
                    Age = "39",
                    Experience = "9 Years",
                    Status = 5
               },
                new TestModel
                {
                    Id = 10,
                    Avatar = "9.png",
                    Full_name = "Merline Penhalewick",
                    Post = "Junior Executive",
                    Email = "mpenhalewick9@php.net",
                    City = "Kanuma",
                    Start_date = "04/19/2021",
                    Salary = "$15939.52",
                    Age = "23",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 11,
                    Avatar = "",
                    Full_name = "De Falloon",
                    Post = "Sales Representative",
                    Email = "dfalloona@ifeng.com",
                    City = "Colima",
                    Start_date = "06/12/2021",
                    Salary = "$19252.12",
                    Age = "30",
                    Experience = "0 Year",
                    Status = 4
               },
                new TestModel
                {
                    Id = 12,
                    Avatar = "",
                    Full_name = "Cyrus Gornal",
                    Post = "Senior Sales Associate",
                    Email = "cgornalb@fda.gov",
                    City = "Boro Utara",
                    Start_date = "12/09/2021",
                    Salary = "$16745.47",
                    Age = "22",
                    Experience = "2 Years",
                    Status = 4
               },
                new TestModel
                {
                    Id = 13,
                    Avatar = "",
                    Full_name = "Tallou Balf",
                    Post = "Staff Accountant",
                    Email = "tbalfc@sina.com.cn",
                    City = "Siliana",
                    Start_date = "01/21/2021",
                    Salary = "$15488.53",
                    Age = "36",
                    Experience = "6 Years",
                    Status = 4
               },
                new TestModel
                {
                    Id = 14,
                    Avatar = "",
                    Full_name = "Othilia Extill",
                    Post = "Associate Professor",
                    Email = "oextilld@theatlantic.com",
                    City = "Brzyska",
                    Start_date = "02/01/2021",
                    Salary = "$18442.34",
                    Age = "43",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 15,
                    Avatar = "",
                    Full_name = "Wilmar Bourton",
                    Post = "Administrative Assistant",
                    Email = "wbourtone@sakura.ne.jp",
                    City = "Bích Động",
                    Start_date = "04/25/2021",
                    Salary = "$13304.45",
                    Age = "19",
                    Experience = "9 Years",
                    Status = 5
               },
                                new TestModel
                {
                    Id =  1,
                    Avatar =  "10.png",
                    Full_name =  "Korrie O'Crevy",
                    Post =  "Nuclear Power Engineer",
                    Email =  "kocrevy0@thetimes.co.uk",
                    City =  "Krasnosilka",
                    Start_date =  "09/23/2021",
                    Salary =  "$23896.35",
                    Age =  "61",
                    Experience =  "1 Year",
                    Status = 2
                },
                new TestModel
                {
                    Id = 2,
                    Avatar = "1.png",
                    Full_name = "Bailie Coulman",
                    Post = "VP Quality Control",
                    Email = "bcoulman1@yolasite.com",
                    City = "Hinigaran",
                    Start_date = "05/20/2021",
                    Salary = "$13633.69",
                    Age = "63",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 3,
                    Avatar = "9.png",
                    Full_name = "Stella Ganderton",
                    Post = "Operator",
                    Email = "sganderton2@tuttocitta.it",
                    City = "Golcowa",
                    Start_date = "03/24/2021",
                    Salary = "$13076.28",
                    Age = "66",
                    Experience = "6 Years",
                    Status = 5
               },
                new TestModel
                {
                    Id = 4,
                    Avatar = "10.png",
                    Full_name = "Dorolice Crossman",
                    Post = "Cost Accountant",
                    Email = "dcrossman3@google.co.jp",
                    City = "Paquera",
                    Start_date = "12/03/2021",
                    Salary = "$12336.17",
                    Age = "22",
                    Experience = "2 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 5,
                    Avatar = "",
                    Full_name = "Harmonia Nisius",
                    Post = "Senior Cost Accountant",
                    Email = "hnisius4@gnu.org",
                    City = "Lucan",
                    Start_date = "08/25/2021",
                    Salary = "$10909.52",
                    Age = "33",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 6,
                    Avatar = "",
                    Full_name = "Genevra Honeywood",
                    Post = "Geologist",
                    Email = "ghoneywood5@narod.ru",
                    City = "Maofan",
                    Start_date = "06/01/2021",
                    Salary = "$17803.80",
                    Age = "61",
                    Experience = "1 Year",
                    Status = 1
               },
                new TestModel
                {
                    Id = 7,
                    Avatar = "",
                    Full_name = "Eileen Diehn",
                    Post = "Environmental Specialist",
                    Email = "ediehn6@163.com",
                    City = "Lampuyang",
                    Start_date = "10/15/2021",
                    Salary = "$18991.67",
                    Age = "59",
                    Experience = "9 Years",
                    Status = 3
               },
                new TestModel
                {
                    Id = 8,
                    Avatar = "9.png",
                    Full_name = "Richardo Aldren",
                    Post = "Senior Sales Associate",
                    Email = "raldren7@mtv.com",
                    City = "Skoghall",
                    Start_date = "11/05/2021",
                    Salary = "$19230.13",
                    Age = "55",
                    Experience = "5 Years",
                    Status = 3
               },
                new TestModel
                {
                    Id = 9,
                    Avatar = "2.png",
                    Full_name = "Allyson Moakler",
                    Post = "Safety Technician",
                    Email = "amoakler8@shareasale.com",
                    City = "Mogilany",
                    Start_date = "12/29/2021",
                    Salary = "$11677.32",
                    Age = "39",
                    Experience = "9 Years",
                    Status = 5
               },
                new TestModel
                {
                    Id = 10,
                    Avatar = "9.png",
                    Full_name = "Merline Penhalewick",
                    Post = "Junior Executive",
                    Email = "mpenhalewick9@php.net",
                    City = "Kanuma",
                    Start_date = "04/19/2021",
                    Salary = "$15939.52",
                    Age = "23",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 11,
                    Avatar = "",
                    Full_name = "De Falloon",
                    Post = "Sales Representative",
                    Email = "dfalloona@ifeng.com",
                    City = "Colima",
                    Start_date = "06/12/2021",
                    Salary = "$19252.12",
                    Age = "30",
                    Experience = "0 Year",
                    Status = 4
               },
                new TestModel
                {
                    Id = 12,
                    Avatar = "",
                    Full_name = "Cyrus Gornal",
                    Post = "Senior Sales Associate",
                    Email = "cgornalb@fda.gov",
                    City = "Boro Utara",
                    Start_date = "12/09/2021",
                    Salary = "$16745.47",
                    Age = "22",
                    Experience = "2 Years",
                    Status = 4
               },
                new TestModel
                {
                    Id = 13,
                    Avatar = "",
                    Full_name = "Tallou Balf",
                    Post = "Staff Accountant",
                    Email = "tbalfc@sina.com.cn",
                    City = "Siliana",
                    Start_date = "01/21/2021",
                    Salary = "$15488.53",
                    Age = "36",
                    Experience = "6 Years",
                    Status = 4
               },
                new TestModel
                {
                    Id = 14,
                    Avatar = "",
                    Full_name = "Othilia Extill",
                    Post = "Associate Professor",
                    Email = "oextilld@theatlantic.com",
                    City = "Brzyska",
                    Start_date = "02/01/2021",
                    Salary = "$18442.34",
                    Age = "43",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 15,
                    Avatar = "",
                    Full_name = "Wilmar Bourton",
                    Post = "Administrative Assistant",
                    Email = "wbourtone@sakura.ne.jp",
                    City = "Bích Động",
                    Start_date = "04/25/2021",
                    Salary = "$13304.45",
                    Age = "19",
                    Experience = "9 Years",
                    Status = 5
               },
                                new TestModel
                {
                    Id =  1,
                    Avatar =  "10.png",
                    Full_name =  "Korrie O'Crevy",
                    Post =  "Nuclear Power Engineer",
                    Email =  "kocrevy0@thetimes.co.uk",
                    City =  "Krasnosilka",
                    Start_date =  "09/23/2021",
                    Salary =  "$23896.35",
                    Age =  "61",
                    Experience =  "1 Year",
                    Status = 2
                },
                new TestModel
                {
                    Id = 2,
                    Avatar = "1.png",
                    Full_name = "Bailie Coulman",
                    Post = "VP Quality Control",
                    Email = "bcoulman1@yolasite.com",
                    City = "Hinigaran",
                    Start_date = "05/20/2021",
                    Salary = "$13633.69",
                    Age = "63",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 3,
                    Avatar = "9.png",
                    Full_name = "Stella Ganderton",
                    Post = "Operator",
                    Email = "sganderton2@tuttocitta.it",
                    City = "Golcowa",
                    Start_date = "03/24/2021",
                    Salary = "$13076.28",
                    Age = "66",
                    Experience = "6 Years",
                    Status = 5
               },
                new TestModel
                {
                    Id = 4,
                    Avatar = "10.png",
                    Full_name = "Dorolice Crossman",
                    Post = "Cost Accountant",
                    Email = "dcrossman3@google.co.jp",
                    City = "Paquera",
                    Start_date = "12/03/2021",
                    Salary = "$12336.17",
                    Age = "22",
                    Experience = "2 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 5,
                    Avatar = "",
                    Full_name = "Harmonia Nisius",
                    Post = "Senior Cost Accountant",
                    Email = "hnisius4@gnu.org",
                    City = "Lucan",
                    Start_date = "08/25/2021",
                    Salary = "$10909.52",
                    Age = "33",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 6,
                    Avatar = "",
                    Full_name = "Genevra Honeywood",
                    Post = "Geologist",
                    Email = "ghoneywood5@narod.ru",
                    City = "Maofan",
                    Start_date = "06/01/2021",
                    Salary = "$17803.80",
                    Age = "61",
                    Experience = "1 Year",
                    Status = 1
               },
                new TestModel
                {
                    Id = 7,
                    Avatar = "",
                    Full_name = "Eileen Diehn",
                    Post = "Environmental Specialist",
                    Email = "ediehn6@163.com",
                    City = "Lampuyang",
                    Start_date = "10/15/2021",
                    Salary = "$18991.67",
                    Age = "59",
                    Experience = "9 Years",
                    Status = 3
               },
                new TestModel
                {
                    Id = 8,
                    Avatar = "9.png",
                    Full_name = "Richardo Aldren",
                    Post = "Senior Sales Associate",
                    Email = "raldren7@mtv.com",
                    City = "Skoghall",
                    Start_date = "11/05/2021",
                    Salary = "$19230.13",
                    Age = "55",
                    Experience = "5 Years",
                    Status = 3
               },
                new TestModel
                {
                    Id = 9,
                    Avatar = "2.png",
                    Full_name = "Allyson Moakler",
                    Post = "Safety Technician",
                    Email = "amoakler8@shareasale.com",
                    City = "Mogilany",
                    Start_date = "12/29/2021",
                    Salary = "$11677.32",
                    Age = "39",
                    Experience = "9 Years",
                    Status = 5
               },
                new TestModel
                {
                    Id = 10,
                    Avatar = "9.png",
                    Full_name = "Merline Penhalewick",
                    Post = "Junior Executive",
                    Email = "mpenhalewick9@php.net",
                    City = "Kanuma",
                    Start_date = "04/19/2021",
                    Salary = "$15939.52",
                    Age = "23",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 11,
                    Avatar = "",
                    Full_name = "De Falloon",
                    Post = "Sales Representative",
                    Email = "dfalloona@ifeng.com",
                    City = "Colima",
                    Start_date = "06/12/2021",
                    Salary = "$19252.12",
                    Age = "30",
                    Experience = "0 Year",
                    Status = 4
               },
                new TestModel
                {
                    Id = 12,
                    Avatar = "",
                    Full_name = "Cyrus Gornal",
                    Post = "Senior Sales Associate",
                    Email = "cgornalb@fda.gov",
                    City = "Boro Utara",
                    Start_date = "12/09/2021",
                    Salary = "$16745.47",
                    Age = "22",
                    Experience = "2 Years",
                    Status = 4
               },
                new TestModel
                {
                    Id = 13,
                    Avatar = "",
                    Full_name = "Tallou Balf",
                    Post = "Staff Accountant",
                    Email = "tbalfc@sina.com.cn",
                    City = "Siliana",
                    Start_date = "01/21/2021",
                    Salary = "$15488.53",
                    Age = "36",
                    Experience = "6 Years",
                    Status = 4
               },
                new TestModel
                {
                    Id = 14,
                    Avatar = "",
                    Full_name = "Othilia Extill",
                    Post = "Associate Professor",
                    Email = "oextilld@theatlantic.com",
                    City = "Brzyska",
                    Start_date = "02/01/2021",
                    Salary = "$18442.34",
                    Age = "43",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 15,
                    Avatar = "",
                    Full_name = "Wilmar Bourton",
                    Post = "Administrative Assistant",
                    Email = "wbourtone@sakura.ne.jp",
                    City = "Bích Động",
                    Start_date = "04/25/2021",
                    Salary = "$13304.45",
                    Age = "19",
                    Experience = "9 Years",
                    Status = 5
               },
                                new TestModel
                {
                    Id =  1,
                    Avatar =  "10.png",
                    Full_name =  "Korrie O'Crevy",
                    Post =  "Nuclear Power Engineer",
                    Email =  "kocrevy0@thetimes.co.uk",
                    City =  "Krasnosilka",
                    Start_date =  "09/23/2021",
                    Salary =  "$23896.35",
                    Age =  "61",
                    Experience =  "1 Year",
                    Status = 2
                },
                new TestModel
                {
                    Id = 2,
                    Avatar = "1.png",
                    Full_name = "Bailie Coulman",
                    Post = "VP Quality Control",
                    Email = "bcoulman1@yolasite.com",
                    City = "Hinigaran",
                    Start_date = "05/20/2021",
                    Salary = "$13633.69",
                    Age = "63",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 3,
                    Avatar = "9.png",
                    Full_name = "Stella Ganderton",
                    Post = "Operator",
                    Email = "sganderton2@tuttocitta.it",
                    City = "Golcowa",
                    Start_date = "03/24/2021",
                    Salary = "$13076.28",
                    Age = "66",
                    Experience = "6 Years",
                    Status = 5
               },
                new TestModel
                {
                    Id = 4,
                    Avatar = "10.png",
                    Full_name = "Dorolice Crossman",
                    Post = "Cost Accountant",
                    Email = "dcrossman3@google.co.jp",
                    City = "Paquera",
                    Start_date = "12/03/2021",
                    Salary = "$12336.17",
                    Age = "22",
                    Experience = "2 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 5,
                    Avatar = "",
                    Full_name = "Harmonia Nisius",
                    Post = "Senior Cost Accountant",
                    Email = "hnisius4@gnu.org",
                    City = "Lucan",
                    Start_date = "08/25/2021",
                    Salary = "$10909.52",
                    Age = "33",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 6,
                    Avatar = "",
                    Full_name = "Genevra Honeywood",
                    Post = "Geologist",
                    Email = "ghoneywood5@narod.ru",
                    City = "Maofan",
                    Start_date = "06/01/2021",
                    Salary = "$17803.80",
                    Age = "61",
                    Experience = "1 Year",
                    Status = 1
               },
                new TestModel
                {
                    Id = 7,
                    Avatar = "",
                    Full_name = "Eileen Diehn",
                    Post = "Environmental Specialist",
                    Email = "ediehn6@163.com",
                    City = "Lampuyang",
                    Start_date = "10/15/2021",
                    Salary = "$18991.67",
                    Age = "59",
                    Experience = "9 Years",
                    Status = 3
               },
                new TestModel
                {
                    Id = 8,
                    Avatar = "9.png",
                    Full_name = "Richardo Aldren",
                    Post = "Senior Sales Associate",
                    Email = "raldren7@mtv.com",
                    City = "Skoghall",
                    Start_date = "11/05/2021",
                    Salary = "$19230.13",
                    Age = "55",
                    Experience = "5 Years",
                    Status = 3
               },
                new TestModel
                {
                    Id = 9,
                    Avatar = "2.png",
                    Full_name = "Allyson Moakler",
                    Post = "Safety Technician",
                    Email = "amoakler8@shareasale.com",
                    City = "Mogilany",
                    Start_date = "12/29/2021",
                    Salary = "$11677.32",
                    Age = "39",
                    Experience = "9 Years",
                    Status = 5
               },
                new TestModel
                {
                    Id = 10,
                    Avatar = "9.png",
                    Full_name = "Merline Penhalewick",
                    Post = "Junior Executive",
                    Email = "mpenhalewick9@php.net",
                    City = "Kanuma",
                    Start_date = "04/19/2021",
                    Salary = "$15939.52",
                    Age = "23",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 11,
                    Avatar = "",
                    Full_name = "De Falloon",
                    Post = "Sales Representative",
                    Email = "dfalloona@ifeng.com",
                    City = "Colima",
                    Start_date = "06/12/2021",
                    Salary = "$19252.12",
                    Age = "30",
                    Experience = "0 Year",
                    Status = 4
               },
                new TestModel
                {
                    Id = 12,
                    Avatar = "",
                    Full_name = "Cyrus Gornal",
                    Post = "Senior Sales Associate",
                    Email = "cgornalb@fda.gov",
                    City = "Boro Utara",
                    Start_date = "12/09/2021",
                    Salary = "$16745.47",
                    Age = "22",
                    Experience = "2 Years",
                    Status = 4
               },
                new TestModel
                {
                    Id = 13,
                    Avatar = "",
                    Full_name = "Tallou Balf",
                    Post = "Staff Accountant",
                    Email = "tbalfc@sina.com.cn",
                    City = "Siliana",
                    Start_date = "01/21/2021",
                    Salary = "$15488.53",
                    Age = "36",
                    Experience = "6 Years",
                    Status = 4
               },
                new TestModel
                {
                    Id = 14,
                    Avatar = "",
                    Full_name = "Othilia Extill",
                    Post = "Associate Professor",
                    Email = "oextilld@theatlantic.com",
                    City = "Brzyska",
                    Start_date = "02/01/2021",
                    Salary = "$18442.34",
                    Age = "43",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 15,
                    Avatar = "",
                    Full_name = "Wilmar Bourton",
                    Post = "Administrative Assistant",
                    Email = "wbourtone@sakura.ne.jp",
                    City = "Bích Động",
                    Start_date = "04/25/2021",
                    Salary = "$13304.45",
                    Age = "19",
                    Experience = "9 Years",
                    Status = 5
               },
                                new TestModel
                {
                    Id =  1,
                    Avatar =  "10.png",
                    Full_name =  "Korrie O'Crevy",
                    Post =  "Nuclear Power Engineer",
                    Email =  "kocrevy0@thetimes.co.uk",
                    City =  "Krasnosilka",
                    Start_date =  "09/23/2021",
                    Salary =  "$23896.35",
                    Age =  "61",
                    Experience =  "1 Year",
                    Status = 2
                },
                new TestModel
                {
                    Id = 2,
                    Avatar = "1.png",
                    Full_name = "Bailie Coulman",
                    Post = "VP Quality Control",
                    Email = "bcoulman1@yolasite.com",
                    City = "Hinigaran",
                    Start_date = "05/20/2021",
                    Salary = "$13633.69",
                    Age = "63",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 3,
                    Avatar = "9.png",
                    Full_name = "Stella Ganderton",
                    Post = "Operator",
                    Email = "sganderton2@tuttocitta.it",
                    City = "Golcowa",
                    Start_date = "03/24/2021",
                    Salary = "$13076.28",
                    Age = "66",
                    Experience = "6 Years",
                    Status = 5
               },
                new TestModel
                {
                    Id = 4,
                    Avatar = "10.png",
                    Full_name = "Dorolice Crossman",
                    Post = "Cost Accountant",
                    Email = "dcrossman3@google.co.jp",
                    City = "Paquera",
                    Start_date = "12/03/2021",
                    Salary = "$12336.17",
                    Age = "22",
                    Experience = "2 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 5,
                    Avatar = "",
                    Full_name = "Harmonia Nisius",
                    Post = "Senior Cost Accountant",
                    Email = "hnisius4@gnu.org",
                    City = "Lucan",
                    Start_date = "08/25/2021",
                    Salary = "$10909.52",
                    Age = "33",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 6,
                    Avatar = "",
                    Full_name = "Genevra Honeywood",
                    Post = "Geologist",
                    Email = "ghoneywood5@narod.ru",
                    City = "Maofan",
                    Start_date = "06/01/2021",
                    Salary = "$17803.80",
                    Age = "61",
                    Experience = "1 Year",
                    Status = 1
               },
                new TestModel
                {
                    Id = 7,
                    Avatar = "",
                    Full_name = "Eileen Diehn",
                    Post = "Environmental Specialist",
                    Email = "ediehn6@163.com",
                    City = "Lampuyang",
                    Start_date = "10/15/2021",
                    Salary = "$18991.67",
                    Age = "59",
                    Experience = "9 Years",
                    Status = 3
               },
                new TestModel
                {
                    Id = 8,
                    Avatar = "9.png",
                    Full_name = "Richardo Aldren",
                    Post = "Senior Sales Associate",
                    Email = "raldren7@mtv.com",
                    City = "Skoghall",
                    Start_date = "11/05/2021",
                    Salary = "$19230.13",
                    Age = "55",
                    Experience = "5 Years",
                    Status = 3
               },
                new TestModel
                {
                    Id = 9,
                    Avatar = "2.png",
                    Full_name = "Allyson Moakler",
                    Post = "Safety Technician",
                    Email = "amoakler8@shareasale.com",
                    City = "Mogilany",
                    Start_date = "12/29/2021",
                    Salary = "$11677.32",
                    Age = "39",
                    Experience = "9 Years",
                    Status = 5
               },
                new TestModel
                {
                    Id = 10,
                    Avatar = "9.png",
                    Full_name = "Merline Penhalewick",
                    Post = "Junior Executive",
                    Email = "mpenhalewick9@php.net",
                    City = "Kanuma",
                    Start_date = "04/19/2021",
                    Salary = "$15939.52",
                    Age = "23",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 11,
                    Avatar = "",
                    Full_name = "De Falloon",
                    Post = "Sales Representative",
                    Email = "dfalloona@ifeng.com",
                    City = "Colima",
                    Start_date = "06/12/2021",
                    Salary = "$19252.12",
                    Age = "30",
                    Experience = "0 Year",
                    Status = 4
               },
                new TestModel
                {
                    Id = 12,
                    Avatar = "",
                    Full_name = "Cyrus Gornal",
                    Post = "Senior Sales Associate",
                    Email = "cgornalb@fda.gov",
                    City = "Boro Utara",
                    Start_date = "12/09/2021",
                    Salary = "$16745.47",
                    Age = "22",
                    Experience = "2 Years",
                    Status = 4
               },
                new TestModel
                {
                    Id = 13,
                    Avatar = "",
                    Full_name = "Tallou Balf",
                    Post = "Staff Accountant",
                    Email = "tbalfc@sina.com.cn",
                    City = "Siliana",
                    Start_date = "01/21/2021",
                    Salary = "$15488.53",
                    Age = "36",
                    Experience = "6 Years",
                    Status = 4
               },
                new TestModel
                {
                    Id = 14,
                    Avatar = "",
                    Full_name = "Othilia Extill",
                    Post = "Associate Professor",
                    Email = "oextilld@theatlantic.com",
                    City = "Brzyska",
                    Start_date = "02/01/2021",
                    Salary = "$18442.34",
                    Age = "43",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 15,
                    Avatar = "",
                    Full_name = "Wilmar Bourton",
                    Post = "Administrative Assistant",
                    Email = "wbourtone@sakura.ne.jp",
                    City = "Bích Động",
                    Start_date = "04/25/2021",
                    Salary = "$13304.45",
                    Age = "19",
                    Experience = "9 Years",
                    Status = 5
               },
                                new TestModel
                {
                    Id =  1,
                    Avatar =  "10.png",
                    Full_name =  "Korrie O'Crevy",
                    Post =  "Nuclear Power Engineer",
                    Email =  "kocrevy0@thetimes.co.uk",
                    City =  "Krasnosilka",
                    Start_date =  "09/23/2021",
                    Salary =  "$23896.35",
                    Age =  "61",
                    Experience =  "1 Year",
                    Status = 2
                },
                new TestModel
                {
                    Id = 2,
                    Avatar = "1.png",
                    Full_name = "Bailie Coulman",
                    Post = "VP Quality Control",
                    Email = "bcoulman1@yolasite.com",
                    City = "Hinigaran",
                    Start_date = "05/20/2021",
                    Salary = "$13633.69",
                    Age = "63",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 3,
                    Avatar = "9.png",
                    Full_name = "Stella Ganderton",
                    Post = "Operator",
                    Email = "sganderton2@tuttocitta.it",
                    City = "Golcowa",
                    Start_date = "03/24/2021",
                    Salary = "$13076.28",
                    Age = "66",
                    Experience = "6 Years",
                    Status = 5
               },
                new TestModel
                {
                    Id = 4,
                    Avatar = "10.png",
                    Full_name = "Dorolice Crossman",
                    Post = "Cost Accountant",
                    Email = "dcrossman3@google.co.jp",
                    City = "Paquera",
                    Start_date = "12/03/2021",
                    Salary = "$12336.17",
                    Age = "22",
                    Experience = "2 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 5,
                    Avatar = "",
                    Full_name = "Harmonia Nisius",
                    Post = "Senior Cost Accountant",
                    Email = "hnisius4@gnu.org",
                    City = "Lucan",
                    Start_date = "08/25/2021",
                    Salary = "$10909.52",
                    Age = "33",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 6,
                    Avatar = "",
                    Full_name = "Genevra Honeywood",
                    Post = "Geologist",
                    Email = "ghoneywood5@narod.ru",
                    City = "Maofan",
                    Start_date = "06/01/2021",
                    Salary = "$17803.80",
                    Age = "61",
                    Experience = "1 Year",
                    Status = 1
               },
                new TestModel
                {
                    Id = 7,
                    Avatar = "",
                    Full_name = "Eileen Diehn",
                    Post = "Environmental Specialist",
                    Email = "ediehn6@163.com",
                    City = "Lampuyang",
                    Start_date = "10/15/2021",
                    Salary = "$18991.67",
                    Age = "59",
                    Experience = "9 Years",
                    Status = 3
               },
                new TestModel
                {
                    Id = 8,
                    Avatar = "9.png",
                    Full_name = "Richardo Aldren",
                    Post = "Senior Sales Associate",
                    Email = "raldren7@mtv.com",
                    City = "Skoghall",
                    Start_date = "11/05/2021",
                    Salary = "$19230.13",
                    Age = "55",
                    Experience = "5 Years",
                    Status = 3
               },
                new TestModel
                {
                    Id = 9,
                    Avatar = "2.png",
                    Full_name = "Allyson Moakler",
                    Post = "Safety Technician",
                    Email = "amoakler8@shareasale.com",
                    City = "Mogilany",
                    Start_date = "12/29/2021",
                    Salary = "$11677.32",
                    Age = "39",
                    Experience = "9 Years",
                    Status = 5
               },
                new TestModel
                {
                    Id = 10,
                    Avatar = "9.png",
                    Full_name = "Merline Penhalewick",
                    Post = "Junior Executive",
                    Email = "mpenhalewick9@php.net",
                    City = "Kanuma",
                    Start_date = "04/19/2021",
                    Salary = "$15939.52",
                    Age = "23",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 11,
                    Avatar = "",
                    Full_name = "De Falloon",
                    Post = "Sales Representative",
                    Email = "dfalloona@ifeng.com",
                    City = "Colima",
                    Start_date = "06/12/2021",
                    Salary = "$19252.12",
                    Age = "30",
                    Experience = "0 Year",
                    Status = 4
               },
                new TestModel
                {
                    Id = 12,
                    Avatar = "",
                    Full_name = "Cyrus Gornal",
                    Post = "Senior Sales Associate",
                    Email = "cgornalb@fda.gov",
                    City = "Boro Utara",
                    Start_date = "12/09/2021",
                    Salary = "$16745.47",
                    Age = "22",
                    Experience = "2 Years",
                    Status = 4
               },
                new TestModel
                {
                    Id = 13,
                    Avatar = "",
                    Full_name = "Tallou Balf",
                    Post = "Staff Accountant",
                    Email = "tbalfc@sina.com.cn",
                    City = "Siliana",
                    Start_date = "01/21/2021",
                    Salary = "$15488.53",
                    Age = "36",
                    Experience = "6 Years",
                    Status = 4
               },
                new TestModel
                {
                    Id = 14,
                    Avatar = "",
                    Full_name = "Othilia Extill",
                    Post = "Associate Professor",
                    Email = "oextilld@theatlantic.com",
                    City = "Brzyska",
                    Start_date = "02/01/2021",
                    Salary = "$18442.34",
                    Age = "43",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 15,
                    Avatar = "",
                    Full_name = "Wilmar Bourton",
                    Post = "Administrative Assistant",
                    Email = "wbourtone@sakura.ne.jp",
                    City = "Bích Động",
                    Start_date = "04/25/2021",
                    Salary = "$13304.45",
                    Age = "19",
                    Experience = "9 Years",
                    Status = 5
               },
                                new TestModel
                {
                    Id =  1,
                    Avatar =  "10.png",
                    Full_name =  "Korrie O'Crevy",
                    Post =  "Nuclear Power Engineer",
                    Email =  "kocrevy0@thetimes.co.uk",
                    City =  "Krasnosilka",
                    Start_date =  "09/23/2021",
                    Salary =  "$23896.35",
                    Age =  "61",
                    Experience =  "1 Year",
                    Status = 2
                },
                new TestModel
                {
                    Id = 2,
                    Avatar = "1.png",
                    Full_name = "Bailie Coulman",
                    Post = "VP Quality Control",
                    Email = "bcoulman1@yolasite.com",
                    City = "Hinigaran",
                    Start_date = "05/20/2021",
                    Salary = "$13633.69",
                    Age = "63",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 3,
                    Avatar = "9.png",
                    Full_name = "Stella Ganderton",
                    Post = "Operator",
                    Email = "sganderton2@tuttocitta.it",
                    City = "Golcowa",
                    Start_date = "03/24/2021",
                    Salary = "$13076.28",
                    Age = "66",
                    Experience = "6 Years",
                    Status = 5
               },
                new TestModel
                {
                    Id = 4,
                    Avatar = "10.png",
                    Full_name = "Dorolice Crossman",
                    Post = "Cost Accountant",
                    Email = "dcrossman3@google.co.jp",
                    City = "Paquera",
                    Start_date = "12/03/2021",
                    Salary = "$12336.17",
                    Age = "22",
                    Experience = "2 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 5,
                    Avatar = "",
                    Full_name = "Harmonia Nisius",
                    Post = "Senior Cost Accountant",
                    Email = "hnisius4@gnu.org",
                    City = "Lucan",
                    Start_date = "08/25/2021",
                    Salary = "$10909.52",
                    Age = "33",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 6,
                    Avatar = "",
                    Full_name = "Genevra Honeywood",
                    Post = "Geologist",
                    Email = "ghoneywood5@narod.ru",
                    City = "Maofan",
                    Start_date = "06/01/2021",
                    Salary = "$17803.80",
                    Age = "61",
                    Experience = "1 Year",
                    Status = 1
               },
                new TestModel
                {
                    Id = 7,
                    Avatar = "",
                    Full_name = "Eileen Diehn",
                    Post = "Environmental Specialist",
                    Email = "ediehn6@163.com",
                    City = "Lampuyang",
                    Start_date = "10/15/2021",
                    Salary = "$18991.67",
                    Age = "59",
                    Experience = "9 Years",
                    Status = 3
               },
                new TestModel
                {
                    Id = 8,
                    Avatar = "9.png",
                    Full_name = "Richardo Aldren",
                    Post = "Senior Sales Associate",
                    Email = "raldren7@mtv.com",
                    City = "Skoghall",
                    Start_date = "11/05/2021",
                    Salary = "$19230.13",
                    Age = "55",
                    Experience = "5 Years",
                    Status = 3
               },
                new TestModel
                {
                    Id = 9,
                    Avatar = "2.png",
                    Full_name = "Allyson Moakler",
                    Post = "Safety Technician",
                    Email = "amoakler8@shareasale.com",
                    City = "Mogilany",
                    Start_date = "12/29/2021",
                    Salary = "$11677.32",
                    Age = "39",
                    Experience = "9 Years",
                    Status = 5
               },
                new TestModel
                {
                    Id = 10,
                    Avatar = "9.png",
                    Full_name = "Merline Penhalewick",
                    Post = "Junior Executive",
                    Email = "mpenhalewick9@php.net",
                    City = "Kanuma",
                    Start_date = "04/19/2021",
                    Salary = "$15939.52",
                    Age = "23",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 11,
                    Avatar = "",
                    Full_name = "De Falloon",
                    Post = "Sales Representative",
                    Email = "dfalloona@ifeng.com",
                    City = "Colima",
                    Start_date = "06/12/2021",
                    Salary = "$19252.12",
                    Age = "30",
                    Experience = "0 Year",
                    Status = 4
               },
                new TestModel
                {
                    Id = 12,
                    Avatar = "",
                    Full_name = "Cyrus Gornal",
                    Post = "Senior Sales Associate",
                    Email = "cgornalb@fda.gov",
                    City = "Boro Utara",
                    Start_date = "12/09/2021",
                    Salary = "$16745.47",
                    Age = "22",
                    Experience = "2 Years",
                    Status = 4
               },
                new TestModel
                {
                    Id = 13,
                    Avatar = "",
                    Full_name = "Tallou Balf",
                    Post = "Staff Accountant",
                    Email = "tbalfc@sina.com.cn",
                    City = "Siliana",
                    Start_date = "01/21/2021",
                    Salary = "$15488.53",
                    Age = "36",
                    Experience = "6 Years",
                    Status = 4
               },
                new TestModel
                {
                    Id = 14,
                    Avatar = "",
                    Full_name = "Othilia Extill",
                    Post = "Associate Professor",
                    Email = "oextilld@theatlantic.com",
                    City = "Brzyska",
                    Start_date = "02/01/2021",
                    Salary = "$18442.34",
                    Age = "43",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 15,
                    Avatar = "",
                    Full_name = "Wilmar Bourton",
                    Post = "Administrative Assistant",
                    Email = "wbourtone@sakura.ne.jp",
                    City = "Bích Động",
                    Start_date = "04/25/2021",
                    Salary = "$13304.45",
                    Age = "19",
                    Experience = "9 Years",
                    Status = 5
               },
                                new TestModel
                {
                    Id =  1,
                    Avatar =  "10.png",
                    Full_name =  "Korrie O'Crevy",
                    Post =  "Nuclear Power Engineer",
                    Email =  "kocrevy0@thetimes.co.uk",
                    City =  "Krasnosilka",
                    Start_date =  "09/23/2021",
                    Salary =  "$23896.35",
                    Age =  "61",
                    Experience =  "1 Year",
                    Status = 2
                },
                new TestModel
                {
                    Id = 2,
                    Avatar = "1.png",
                    Full_name = "Bailie Coulman",
                    Post = "VP Quality Control",
                    Email = "bcoulman1@yolasite.com",
                    City = "Hinigaran",
                    Start_date = "05/20/2021",
                    Salary = "$13633.69",
                    Age = "63",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 3,
                    Avatar = "9.png",
                    Full_name = "Stella Ganderton",
                    Post = "Operator",
                    Email = "sganderton2@tuttocitta.it",
                    City = "Golcowa",
                    Start_date = "03/24/2021",
                    Salary = "$13076.28",
                    Age = "66",
                    Experience = "6 Years",
                    Status = 5
               },
                new TestModel
                {
                    Id = 4,
                    Avatar = "10.png",
                    Full_name = "Dorolice Crossman",
                    Post = "Cost Accountant",
                    Email = "dcrossman3@google.co.jp",
                    City = "Paquera",
                    Start_date = "12/03/2021",
                    Salary = "$12336.17",
                    Age = "22",
                    Experience = "2 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 5,
                    Avatar = "",
                    Full_name = "Harmonia Nisius",
                    Post = "Senior Cost Accountant",
                    Email = "hnisius4@gnu.org",
                    City = "Lucan",
                    Start_date = "08/25/2021",
                    Salary = "$10909.52",
                    Age = "33",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 6,
                    Avatar = "",
                    Full_name = "Genevra Honeywood",
                    Post = "Geologist",
                    Email = "ghoneywood5@narod.ru",
                    City = "Maofan",
                    Start_date = "06/01/2021",
                    Salary = "$17803.80",
                    Age = "61",
                    Experience = "1 Year",
                    Status = 1
               },
                new TestModel
                {
                    Id = 7,
                    Avatar = "",
                    Full_name = "Eileen Diehn",
                    Post = "Environmental Specialist",
                    Email = "ediehn6@163.com",
                    City = "Lampuyang",
                    Start_date = "10/15/2021",
                    Salary = "$18991.67",
                    Age = "59",
                    Experience = "9 Years",
                    Status = 3
               },
                new TestModel
                {
                    Id = 8,
                    Avatar = "9.png",
                    Full_name = "Richardo Aldren",
                    Post = "Senior Sales Associate",
                    Email = "raldren7@mtv.com",
                    City = "Skoghall",
                    Start_date = "11/05/2021",
                    Salary = "$19230.13",
                    Age = "55",
                    Experience = "5 Years",
                    Status = 3
               },
                new TestModel
                {
                    Id = 9,
                    Avatar = "2.png",
                    Full_name = "Allyson Moakler",
                    Post = "Safety Technician",
                    Email = "amoakler8@shareasale.com",
                    City = "Mogilany",
                    Start_date = "12/29/2021",
                    Salary = "$11677.32",
                    Age = "39",
                    Experience = "9 Years",
                    Status = 5
               },
                new TestModel
                {
                    Id = 10,
                    Avatar = "9.png",
                    Full_name = "Merline Penhalewick",
                    Post = "Junior Executive",
                    Email = "mpenhalewick9@php.net",
                    City = "Kanuma",
                    Start_date = "04/19/2021",
                    Salary = "$15939.52",
                    Age = "23",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 11,
                    Avatar = "",
                    Full_name = "De Falloon",
                    Post = "Sales Representative",
                    Email = "dfalloona@ifeng.com",
                    City = "Colima",
                    Start_date = "06/12/2021",
                    Salary = "$19252.12",
                    Age = "30",
                    Experience = "0 Year",
                    Status = 4
               },
                new TestModel
                {
                    Id = 12,
                    Avatar = "",
                    Full_name = "Cyrus Gornal",
                    Post = "Senior Sales Associate",
                    Email = "cgornalb@fda.gov",
                    City = "Boro Utara",
                    Start_date = "12/09/2021",
                    Salary = "$16745.47",
                    Age = "22",
                    Experience = "2 Years",
                    Status = 4
               },
                new TestModel
                {
                    Id = 13,
                    Avatar = "",
                    Full_name = "Tallou Balf",
                    Post = "Staff Accountant",
                    Email = "tbalfc@sina.com.cn",
                    City = "Siliana",
                    Start_date = "01/21/2021",
                    Salary = "$15488.53",
                    Age = "36",
                    Experience = "6 Years",
                    Status = 4
               },
                new TestModel
                {
                    Id = 14,
                    Avatar = "",
                    Full_name = "Othilia Extill",
                    Post = "Associate Professor",
                    Email = "oextilld@theatlantic.com",
                    City = "Brzyska",
                    Start_date = "02/01/2021",
                    Salary = "$18442.34",
                    Age = "43",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 15,
                    Avatar = "",
                    Full_name = "Wilmar Bourton",
                    Post = "Administrative Assistant",
                    Email = "wbourtone@sakura.ne.jp",
                    City = "Bích Động",
                    Start_date = "04/25/2021",
                    Salary = "$13304.45",
                    Age = "19",
                    Experience = "9 Years",
                    Status = 5
               },
                                new TestModel
                {
                    Id =  1,
                    Avatar =  "10.png",
                    Full_name =  "Korrie O'Crevy",
                    Post =  "Nuclear Power Engineer",
                    Email =  "kocrevy0@thetimes.co.uk",
                    City =  "Krasnosilka",
                    Start_date =  "09/23/2021",
                    Salary =  "$23896.35",
                    Age =  "61",
                    Experience =  "1 Year",
                    Status = 2
                },
                new TestModel
                {
                    Id = 2,
                    Avatar = "1.png",
                    Full_name = "Bailie Coulman",
                    Post = "VP Quality Control",
                    Email = "bcoulman1@yolasite.com",
                    City = "Hinigaran",
                    Start_date = "05/20/2021",
                    Salary = "$13633.69",
                    Age = "63",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 3,
                    Avatar = "9.png",
                    Full_name = "Stella Ganderton",
                    Post = "Operator",
                    Email = "sganderton2@tuttocitta.it",
                    City = "Golcowa",
                    Start_date = "03/24/2021",
                    Salary = "$13076.28",
                    Age = "66",
                    Experience = "6 Years",
                    Status = 5
               },
                new TestModel
                {
                    Id = 4,
                    Avatar = "10.png",
                    Full_name = "Dorolice Crossman",
                    Post = "Cost Accountant",
                    Email = "dcrossman3@google.co.jp",
                    City = "Paquera",
                    Start_date = "12/03/2021",
                    Salary = "$12336.17",
                    Age = "22",
                    Experience = "2 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 5,
                    Avatar = "",
                    Full_name = "Harmonia Nisius",
                    Post = "Senior Cost Accountant",
                    Email = "hnisius4@gnu.org",
                    City = "Lucan",
                    Start_date = "08/25/2021",
                    Salary = "$10909.52",
                    Age = "33",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 6,
                    Avatar = "",
                    Full_name = "Genevra Honeywood",
                    Post = "Geologist",
                    Email = "ghoneywood5@narod.ru",
                    City = "Maofan",
                    Start_date = "06/01/2021",
                    Salary = "$17803.80",
                    Age = "61",
                    Experience = "1 Year",
                    Status = 1
               },
                new TestModel
                {
                    Id = 7,
                    Avatar = "",
                    Full_name = "Eileen Diehn",
                    Post = "Environmental Specialist",
                    Email = "ediehn6@163.com",
                    City = "Lampuyang",
                    Start_date = "10/15/2021",
                    Salary = "$18991.67",
                    Age = "59",
                    Experience = "9 Years",
                    Status = 3
               },
                new TestModel
                {
                    Id = 8,
                    Avatar = "9.png",
                    Full_name = "Richardo Aldren",
                    Post = "Senior Sales Associate",
                    Email = "raldren7@mtv.com",
                    City = "Skoghall",
                    Start_date = "11/05/2021",
                    Salary = "$19230.13",
                    Age = "55",
                    Experience = "5 Years",
                    Status = 3
               },
                new TestModel
                {
                    Id = 9,
                    Avatar = "2.png",
                    Full_name = "Allyson Moakler",
                    Post = "Safety Technician",
                    Email = "amoakler8@shareasale.com",
                    City = "Mogilany",
                    Start_date = "12/29/2021",
                    Salary = "$11677.32",
                    Age = "39",
                    Experience = "9 Years",
                    Status = 5
               },
                new TestModel
                {
                    Id = 10,
                    Avatar = "9.png",
                    Full_name = "Merline Penhalewick",
                    Post = "Junior Executive",
                    Email = "mpenhalewick9@php.net",
                    City = "Kanuma",
                    Start_date = "04/19/2021",
                    Salary = "$15939.52",
                    Age = "23",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 11,
                    Avatar = "",
                    Full_name = "De Falloon",
                    Post = "Sales Representative",
                    Email = "dfalloona@ifeng.com",
                    City = "Colima",
                    Start_date = "06/12/2021",
                    Salary = "$19252.12",
                    Age = "30",
                    Experience = "0 Year",
                    Status = 4
               },
                new TestModel
                {
                    Id = 12,
                    Avatar = "",
                    Full_name = "Cyrus Gornal",
                    Post = "Senior Sales Associate",
                    Email = "cgornalb@fda.gov",
                    City = "Boro Utara",
                    Start_date = "12/09/2021",
                    Salary = "$16745.47",
                    Age = "22",
                    Experience = "2 Years",
                    Status = 4
               },
                new TestModel
                {
                    Id = 13,
                    Avatar = "",
                    Full_name = "Tallou Balf",
                    Post = "Staff Accountant",
                    Email = "tbalfc@sina.com.cn",
                    City = "Siliana",
                    Start_date = "01/21/2021",
                    Salary = "$15488.53",
                    Age = "36",
                    Experience = "6 Years",
                    Status = 4
               },
                new TestModel
                {
                    Id = 14,
                    Avatar = "",
                    Full_name = "Othilia Extill",
                    Post = "Associate Professor",
                    Email = "oextilld@theatlantic.com",
                    City = "Brzyska",
                    Start_date = "02/01/2021",
                    Salary = "$18442.34",
                    Age = "43",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 15,
                    Avatar = "",
                    Full_name = "Wilmar Bourton",
                    Post = "Administrative Assistant",
                    Email = "wbourtone@sakura.ne.jp",
                    City = "Bích Động",
                    Start_date = "04/25/2021",
                    Salary = "$13304.45",
                    Age = "19",
                    Experience = "9 Years",
                    Status = 5
               },
                                new TestModel
                {
                    Id =  1,
                    Avatar =  "10.png",
                    Full_name =  "Korrie O'Crevy",
                    Post =  "Nuclear Power Engineer",
                    Email =  "kocrevy0@thetimes.co.uk",
                    City =  "Krasnosilka",
                    Start_date =  "09/23/2021",
                    Salary =  "$23896.35",
                    Age =  "61",
                    Experience =  "1 Year",
                    Status = 2
                },
                new TestModel
                {
                    Id = 2,
                    Avatar = "1.png",
                    Full_name = "Bailie Coulman",
                    Post = "VP Quality Control",
                    Email = "bcoulman1@yolasite.com",
                    City = "Hinigaran",
                    Start_date = "05/20/2021",
                    Salary = "$13633.69",
                    Age = "63",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 3,
                    Avatar = "9.png",
                    Full_name = "Stella Ganderton",
                    Post = "Operator",
                    Email = "sganderton2@tuttocitta.it",
                    City = "Golcowa",
                    Start_date = "03/24/2021",
                    Salary = "$13076.28",
                    Age = "66",
                    Experience = "6 Years",
                    Status = 5
               },
                new TestModel
                {
                    Id = 4,
                    Avatar = "10.png",
                    Full_name = "Dorolice Crossman",
                    Post = "Cost Accountant",
                    Email = "dcrossman3@google.co.jp",
                    City = "Paquera",
                    Start_date = "12/03/2021",
                    Salary = "$12336.17",
                    Age = "22",
                    Experience = "2 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 5,
                    Avatar = "",
                    Full_name = "Harmonia Nisius",
                    Post = "Senior Cost Accountant",
                    Email = "hnisius4@gnu.org",
                    City = "Lucan",
                    Start_date = "08/25/2021",
                    Salary = "$10909.52",
                    Age = "33",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 6,
                    Avatar = "",
                    Full_name = "Genevra Honeywood",
                    Post = "Geologist",
                    Email = "ghoneywood5@narod.ru",
                    City = "Maofan",
                    Start_date = "06/01/2021",
                    Salary = "$17803.80",
                    Age = "61",
                    Experience = "1 Year",
                    Status = 1
               },
                new TestModel
                {
                    Id = 7,
                    Avatar = "",
                    Full_name = "Eileen Diehn",
                    Post = "Environmental Specialist",
                    Email = "ediehn6@163.com",
                    City = "Lampuyang",
                    Start_date = "10/15/2021",
                    Salary = "$18991.67",
                    Age = "59",
                    Experience = "9 Years",
                    Status = 3
               },
                new TestModel
                {
                    Id = 8,
                    Avatar = "9.png",
                    Full_name = "Richardo Aldren",
                    Post = "Senior Sales Associate",
                    Email = "raldren7@mtv.com",
                    City = "Skoghall",
                    Start_date = "11/05/2021",
                    Salary = "$19230.13",
                    Age = "55",
                    Experience = "5 Years",
                    Status = 3
               },
                new TestModel
                {
                    Id = 9,
                    Avatar = "2.png",
                    Full_name = "Allyson Moakler",
                    Post = "Safety Technician",
                    Email = "amoakler8@shareasale.com",
                    City = "Mogilany",
                    Start_date = "12/29/2021",
                    Salary = "$11677.32",
                    Age = "39",
                    Experience = "9 Years",
                    Status = 5
               },
                new TestModel
                {
                    Id = 10,
                    Avatar = "9.png",
                    Full_name = "Merline Penhalewick",
                    Post = "Junior Executive",
                    Email = "mpenhalewick9@php.net",
                    City = "Kanuma",
                    Start_date = "04/19/2021",
                    Salary = "$15939.52",
                    Age = "23",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 11,
                    Avatar = "",
                    Full_name = "De Falloon",
                    Post = "Sales Representative",
                    Email = "dfalloona@ifeng.com",
                    City = "Colima",
                    Start_date = "06/12/2021",
                    Salary = "$19252.12",
                    Age = "30",
                    Experience = "0 Year",
                    Status = 4
               },
                new TestModel
                {
                    Id = 12,
                    Avatar = "",
                    Full_name = "Cyrus Gornal",
                    Post = "Senior Sales Associate",
                    Email = "cgornalb@fda.gov",
                    City = "Boro Utara",
                    Start_date = "12/09/2021",
                    Salary = "$16745.47",
                    Age = "22",
                    Experience = "2 Years",
                    Status = 4
               },
                new TestModel
                {
                    Id = 13,
                    Avatar = "",
                    Full_name = "Tallou Balf",
                    Post = "Staff Accountant",
                    Email = "tbalfc@sina.com.cn",
                    City = "Siliana",
                    Start_date = "01/21/2021",
                    Salary = "$15488.53",
                    Age = "36",
                    Experience = "6 Years",
                    Status = 4
               },
                new TestModel
                {
                    Id = 14,
                    Avatar = "",
                    Full_name = "Othilia Extill",
                    Post = "Associate Professor",
                    Email = "oextilld@theatlantic.com",
                    City = "Brzyska",
                    Start_date = "02/01/2021",
                    Salary = "$18442.34",
                    Age = "43",
                    Experience = "3 Years",
                    Status = 2
               },
                new TestModel
                {
                    Id = 15,
                    Avatar = "",
                    Full_name = "Wilmar Bourton",
                    Post = "Administrative Assistant",
                    Email = "wbourtone@sakura.ne.jp",
                    City = "Bích Động",
                    Start_date = "04/25/2021",
                    Salary = "$13304.45",
                    Age = "19",
                    Experience = "9 Years",
                    Status = 5
               },
            };
        }
    }
}
