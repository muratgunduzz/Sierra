namespace Sierra.Models
{
    public class BMEmployee
    {
        // Diğer özellikler...
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PassWord { get; set; }
        public string Sector { get; set; }
        public string Level { get; set; }

        // Düzenleme işlemi için özellikler
        public bool IsEditing { get; set; }
        public string UpdatedName { get; set; }
        public string UpdatedSurname { get; set; }
        public string UpdatePassWord { get; set; }
        public string UpdateSector { get; set; }
        public string UpdateLevel { get; set; }

        // Diğer güncellenecek özellikler...

        // Bu özellikleri doldurmak için bir constructor ekleyebilirsiniz
        public BMEmployee(/*int id, string name, string surname, string password, string sector, string level*/)
        {
            //ID = id;
            //Name = name;
            //Surname = surname;
            //PassWord = password;
            //Sector = sector;
            //Level = level;
            IsEditing = false;
            UpdatedName = string.Empty;
            UpdatedSurname = string.Empty;
            UpdatePassWord = string.Empty;
            UpdateSector = string.Empty;
            UpdateLevel = string.Empty;
            // Diğer güncellenecek özelliklerin başlangıç değerlerini de atayabilirsiniz.
        }
    }

}
