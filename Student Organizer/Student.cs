namespace Student_Organizer
{
    public enum Klassen
    { EA1, EA2, EA3, EA4 }

    internal class Student
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Klassen Klas { get; set; }

        public int PuntenCommunicatie { get; set; }
        public int PuntenProgrammingPrinciples { get; set; }
        public int PuntenWebTech { get; set; }

        public Student()
        {
        }

        public double BerekenTotaalCijfer()
        {
            return (PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech) / 3.0;
        }

        public override string ToString()
        {
            return $"{Klas} - {Naam} - {Leeftijd} | Cijfer: {BerekenTotaalCijfer()}";
        }

        public string GeefOverzicht()
        {
            return $"{Naam}, {Leeftijd} jaar" +
                    $"\nKlas: {Klas}" +
                    "\nCijferrapport" +
                    "\n*************" +
                    $"\nCommunicatie:\t\t{PuntenCommunicatie}" +
                    $"\nProgramming Principles:\t{PuntenProgrammingPrinciples}" +
                    $"\nWeb Technology:\t\t{PuntenWebTech}" +
                    $"\nGemiddelde:\t\t{BerekenTotaalCijfer():0.0}";
        }
    }
}