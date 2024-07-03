namespace Practice.Objects
{
    public class Printer
    {

        public string Value { get; set; }
        private int _number;
        public int Number
        {
            get { return _number; }
            set
            {
                if (value >= 0)
                {
                    _number = value;
                }
            }
        }
        public Printer(string value, int num)
        {
            Value = value;
            Number = num;
        }
        public Printer(int num)
        {
            Value = "";
            Number = num;
        }
        public void Print()
        {
            Console.WriteLine(Value);
            Console.WriteLine(Number);
        }
        /*

        //Printer: private int _number
        //Printer: public int Number { get { return _number } set { if (value) > 0 _number = value }

        //Program -> Main: Printer printer = new Printer(3);  printer.Number = 78;  printer.Number = -8;

        private string _value;
        public string Value
        {
            get { return _value; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _value = value;
                }
            }
        }

        public Printer(string value, int number)
        {
            // _number = number
            _value = value;

            Value = "Sdf";
   
        }
        public void Print()
        {
            Console.WriteLine(Value);
        }
        */
    }
}
