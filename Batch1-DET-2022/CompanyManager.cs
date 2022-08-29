namespace ParamsDemo
{
    internal class CompanyManager
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }

        public string Print()
        {
            return $"Name={Name},Surname={Surname},Phone={Phone}";
        }
    }
}