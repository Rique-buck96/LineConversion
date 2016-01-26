namespace TextFormat.Text
{
    public class Users
    {
        private string _surname;
        private string _title;
        private string _firstname;
        private string _room;
        private string _phone;
        private string _logon;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string Logon
        {
            get { return _logon; }
            set { _logon = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Room
        {
            get { return _room; }
            set { _room = value; }
        }
    }
}
