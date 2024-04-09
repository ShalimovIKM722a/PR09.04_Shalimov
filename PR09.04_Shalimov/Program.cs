
MedCard Medcard1 = new MedCard("Petro", "28.09"  , 106252);
Medcard1.ShowMedCard();


class Patient
{
    private string name;
    private string date_of_birth;
    private uint insurance_number;
    public string Name { get;  }
    public string Date_of_birth { get; set; }
    public uint Insurance_number { get; set; }

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

class MedCard:Patient
{
    public List<string> Diagnoses { get; set; }

    public MedCard(string name, string date_of_birth, uint insurance_number) : base(name, date_of_birth, insurance_number)
    {
        Diagnoses = new List<string>();
    }

    public override void ShowMedCard() {

        string d = "";

        foreach (var diagnosis in Diagnoses)
        {
            d+= diagnosis + " , ";
        }

        Console.WriteLine("Діагнози: " + d);
    }
}

