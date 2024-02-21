namespace MyCompany.Intranet.Core
{
    public class BMIService : IBMIService
    {
        public BMI ProcessBMI(Person person)
        {
            var BMI =  new BMI();
            BMI.index = person.weight/(person.height*person.height);

            if(BMI.index < 18.5)
                BMI.BMIType = BMIType.Low;
            else if (BMI.index >= 18.5 && BMI.index < 24.9)
                BMI.BMIType = BMIType.Normal;
            else if (BMI.index >= 24.9 && BMI.index < 29.9)
                BMI.BMIType = BMIType.Overweight;
            else if (BMI.index >= 29.9)
                BMI.BMIType = BMIType.Obesity;

            return BMI;
        }
    }
}