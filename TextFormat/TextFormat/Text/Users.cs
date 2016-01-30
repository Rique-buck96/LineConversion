namespace TextFormat.Text
{
    public class Users
    {
        public Users(string title, string fName, string lName, string room, string phone, string logon)
        {
            Title = title;
            Surname = lName;
            FirstName = fName;
            Room = room;
            Phone = phone;
            Logon = logon;
        }

        public string Title { get; set; }

        public string Surname { get; set; }

        public string FirstName { get; set; }

        public string Logon { get; set; }

        public string Phone { get; set; }

        public string Room { get; set; }
    }
}
