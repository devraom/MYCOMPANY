namespace MyCompany.Intranet.Core
{
    public class WeightService : IWeightService
    {
        public MarsWeight ProcessMarsWeight(Person person)
        {
            var MarsWeight =  new MarsWeight();

            MarsWeight.marsWeight =  (person.weight*3.7)/9.8;

            return MarsWeight;
        }
    }
}