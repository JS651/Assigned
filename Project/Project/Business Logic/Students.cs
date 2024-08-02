using System;

namespace Project.Business_Logic
{
    class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Dob { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Modulecode { get; set; }
        public string Modulename { get; set; }
        public string ModuleDesc { get; set; }
        public string Link { get; set; }
        public byte[] ImageData { get; set; }

        public Students(int id, string name, string surname, string dob, string gender, string phone, string address, string modulecode, string modulename, string moduleDesc, string link, byte[] imagedata)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Dob = dob;
            Gender = gender;
            Phone = phone;
            Address = address;
            Modulecode = modulecode;
            Modulename = modulename;
            ModuleDesc = moduleDesc;
            Link = link;
            ImageData = imagedata;
        }
    }
}
