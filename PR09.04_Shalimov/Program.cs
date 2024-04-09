



class MedCard
{
    List<string> medCard;
   
    public void AddDiagnoses(List<string> medCard)
    {
        int n;
        Console.WriteLine("Введіть кількість діагнозів");
        n=int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("Введіть " + (i+1)+ "діагноз");
            medCard.Add(Console.ReadLine());
        }
    }

    public string ShowDiagnoses(List<string> medCard)
    {
        string str="Діагнози: ";
        foreach ( var diagnos  in medCard)
        {
            str += diagnos;
        }
        return str;
    }

}


class Patient
{
    private string name;
    private string date_of_birth;
    private uint insurance_number;
    public string Name { get;  }
    public string Date_of_birth { get; set; }
    public uint Insurance_number { get; set; }
    public MedCard medCard = new MedCard();

    public Patient(string name, string date_of_birth, uint insurance_number)
    {
        this.name = name;
        this.date_of_birth = date_of_birth;
        this.insurance_number = insurance_number;
    }

    public virtual void WriteDiagnosis(string diagnosis)
    {
        
    }

    public virtual void ShowMedCard()
    {

    }
}


class Doctor : Patient
{
    private string specialization;
    public Doctor(string name, string date_of_birth, uint insurance_number, string specialization) : base(name, date_of_birth, insurance_number)
    {
        this.specialization = specialization;
    }

    public void SetDiagnosis(Patient patient, string diagnosis)
    {
        patient.WriteDiagnosis(diagnosis);
    }
}


