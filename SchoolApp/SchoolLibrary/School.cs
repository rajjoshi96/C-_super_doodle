using System;
using System.Text;

namespace SchoolLibrary
{
	public class School
	{
		public string SchoolName { get; set; };
		public string SchoolAddress { get; set; };
		public string SchoolNumber { get; set; };
		public string SchoolZip { get; set; };
		public string schoolState { get; set; };

        private string _twitterAddress;
		public string twitterAddress
        {
			get { _twitterAddress };
            set
            {
                if (value.StartsWith('@'))
                {
					_twitterAddress = value;
                }
                else
                {
					throw new Exception("twitter address must begin with '@'");
                }
            }
        }
        //Constructor shortcut ctor and tab twice
        // constructor overloading
        public School()
        {
            SchoolName = "untitled School";
            SchoolNumber = "555-1234";
        }
        public School(string name,string number)
        {
            SchoolName = name;
            SchoolNumber = number;
        }


        //method overloading
        //public float averagethreescores(float a,float b,float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}

        public static int averagethreescores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }


        // function bodied expressions
        public static float averagethreescores(float a, float b, float c) => (a + b + c) / 3;


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(SchoolName);
            sb.AppendLine(SchoolAddress);
            sb.AppendLine(SchoolNumber);
            sb.AppendLineschoolState);
            sb.AppendLine(SchoolZip);
            return base.ToString();
        }
    }
}

