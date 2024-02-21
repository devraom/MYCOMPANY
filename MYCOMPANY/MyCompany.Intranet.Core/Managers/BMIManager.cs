namespace MyCompany.Intranet.Core
{
    public class BMIManager : IMBIManager 
    {
        private readonly IBMIService _service;

        public BMIManager(IBMIService service)
        {
            _service = service;
        }

        public BMI GetBMI(Person person)
        {
            return _service.ProcessBMI(person);
        }
    }
}