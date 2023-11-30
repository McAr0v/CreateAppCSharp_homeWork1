using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CreateAppCSharp
{
    public class FamilyMembers
    {
        /*public int Age { get; set; }
        public string? FullName { get; set; }

        public Gender Gender { get; set; }

        public FamilyMembers? Mother { get; set; }
        public FamilyMembers? Father { get; set; }
        public FamilyMembers? Husband { get; set; }
        public FamilyMembers? Wife { get; set; }

        // Метод создания члена семьи
        public static FamilyMembers CreateMember(
            string name,
            Gender gender,
            int age,
            FamilyMembers? mother = null,
            FamilyMembers? father = null,
            FamilyMembers? husband = null,
            FamilyMembers? wife = null

            )
        {

            return new FamilyMembers { FullName = name, Gender = gender, Age = age, Mother = mother, Father = father, Husband = husband, Wife = wife };

        }

        // Метод получения данных о бабушках
        public FamilyMembers[] GetGrandMother()
        {
            return new FamilyMembers[] { Mother?.Mother, Father?.Mother };

        }

        // Метод получения данных о дедушках
        public FamilyMembers[] GetGrandFather()
        {
            return new FamilyMembers[] { Father?.Father, Mother?.Father };

        }

        // Метод получения данных о родителях
        public FamilyMembers[] GetParents()
        {
            return new FamilyMembers[] { Father, Mother };

        }

        // Метод получения мужа/жены
        public FamilyMembers[] Merried()
        {
            return new FamilyMembers[] { Husband, Wife };

        }

        // Метод отображения мужа/жены в консоль
        public static void ShowMerried(FamilyMembers member)
        {
            // Получаем мужа/жену
            var merried = member.Merried();

            // Показываем в консоли

            // В заголовке - member.FullName - кто женат, GetGenderMerriedWord(member.Gender) - метод получения
            // фразы - женат на, замужем за - в зависимости от гендера

            ShowInConsoleArray(
                merried,
                // Формируем заголовок для красоты
                $"{member.FullName} {GetGenderMerriedWord(member.Gender)}");

        }

        // Метод перевода Man и Woman на русский
        public static string GetGenderName(Gender gender) {

            if (gender == Gender.man) return "Мужской";
            else return "Женский";

        }

        // Метод для заголовка. Возвращает фразу в зависимости от гендера
        public static string GetGenderMerriedWord(Gender gender)
        {

            if (gender == Gender.man) return "женат на";
            else return "замужем за";

        }


        // Метод показа одного члена семьи в консоль
        public static void ShowInConsole (FamilyMembers member, string headline = "")
        {
            if (member != null)
            {
                if (headline != "") Console.WriteLine($"{headline} -------------");
                Console.WriteLine($"Имя - {member.FullName}, Возраст - {member.Age}, Пол - {GetGenderName(member.Gender)}");
            }
            
        }

        // Метод показа в консоль массива с членами семьи
        public static void ShowInConsoleArray(FamilyMembers[] array, string headline = "")
        {
            Console.WriteLine($"{headline} -------------");
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                ShowInConsole (array[i]);

            }

            Console.WriteLine();
            Console.WriteLine();
        }*/

    }
}
