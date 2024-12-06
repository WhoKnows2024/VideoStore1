namespace api.Models.Enums
{
    public class Enums
    {
        public enum RatingEnum
        {
            G = 1,
            PG = 2,
            PG13 = 3,
            R = 4,
            NR = 5
        }
        public enum GeneraEnum
        {   
            Action = 1,
            Animation = 2,
            Comendy =3,
            Crime = 4,
            Docmentary = 5,
            Drama = 6,
            Fantasy = 7,
            Historical = 8,
            Horror = 9,
            Musical = 10,
            Romance = 11,
            SciFi = 12,
            Thriller = 13,
            Westeren = 14
        }
        public enum StatusEnum
        {
            In = 1,
            Out = 2,
            Damaged = 3,
            Missing = 4,
            LateOut = 5
        }
    }
}
