namespace LocalFunctions
{
    class LocalFunctions
    {
        public string FName, LName;

        public LocalFunctions(string FName, string LName)
        {
            this.FName = FName;
            this.LName = LName;
        }
        public string speakName()
        {
            string Fullname = getFullname();

            return $"Hi {Fullname}";

            string getFullname()
            {
                return $"{this.FName} {this.LName}";
            }
        }
    }
}
