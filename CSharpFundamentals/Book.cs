

namespace CSharpFundamentals
{
    public class Book
    {
        private List<double> _grades;

        public string _name;

        public Book(string name)
        {
            _grades = new List<double>();
            _name = name;
        }

        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0)
            {
                _grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid value");
            }
        }

        public Statistics GetStatistics()
        {
            Statistics stats = new();

            for(int i = 0; i < _grades.Count; i++)
            {                
                stats.High = Math.Max(_grades[i], stats.High);
                stats.Low = Math.Min(_grades[i], stats.Low);
                stats.Average += _grades[i];
            }

            stats.Average /= _grades.Count;

            switch (stats.Average)
            {
                case var d when d >= 90.0:
                    stats.Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    stats.Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    stats.Letter = 'C';
                    break;
                case var d when d >= 600.0:
                    stats.Letter = 'D';
                    break;
                default:
                    stats.Letter = 'F';
                    break;
            }

            return stats;
        }
    }
}
