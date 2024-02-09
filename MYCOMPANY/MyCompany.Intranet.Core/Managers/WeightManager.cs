namespace MyCompany.Intranet.Core
{
    public class WeightManager : IWeightManager 
    {
        private readonly IWeightService _service;

        public WeightManager(IWeightService service)
        {
            _service = service;
        }

        public MarsWeight GetMarsWeight(Person person)
        {
            return _service.ProcessMarsWeight(person);
        }
    }
}