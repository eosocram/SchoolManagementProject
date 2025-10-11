namespace Management.Models;

    public class Employee : Person
    {
        public string Enrollment { get; set; }
        public string Responsability { get; set; }
        
        public decimal Salary { get; set; }
        public DateTime AdmissionDate { get; private set; }
        public DateTime? LastDay{ get; set; }

        public Employee(string enrollment, string responsability, DateTime admissionDate)
        {
            Enrollment = enrollment;
            Responsability = responsability;
            AdmissionDate = admissionDate;
            AdmissionDate = admissionDate;
            
            if (AdmissionDate > DateTime.Now)
            {
                throw new ArgumentException("There is no future admission");
            } //Usar operador ternário quando for necessário!
            
        }
        public string CalculateEmployeeServiceTime()
        {
            DateTime finalServiceTime = LastDay ?? DateTime.Now;

            _ = LastDay.HasValue && AdmissionDate > LastDay.Value
                ? throw new ArgumentException("Admission date cannot be later than any termination date!")
                : 0;
            _ = LastDay.HasValue && AdmissionDate == LastDay.Value
                ? throw new ArgumentException("Termination date cannot be the same as admission date.")
                : 0;
            
            int year = finalServiceTime.Year - AdmissionDate.Year;
            int month = finalServiceTime.Month - AdmissionDate.Month;
            int day = finalServiceTime.Day - AdmissionDate.Day;

            if (day < 0)
            {
                month--;
                var previousMonth = finalServiceTime.AddMonths(-1);
                day += DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);
            }

            if (month < 0)
            {
                year--;
                month += 12;
            }
            return $"The total working time was: {year} years, {month} months, {day} days.";
        }
        
        
        
    }
