/* 

 * Доработайте приложение генеалогического дерева таким 
 * образом чтобы программа выводила на экран близких родственников (жену/мужа). 
 * Продумайте способ более красивого вывода с использованием горизонтальных и вертикальных черточек.
 
 */
using System.IO.MemoryMappedFiles;

namespace CreateAppCSharp;

class Program
{
    static void Main(string[] args)
    {
        // Я создал метод, который создает нового члена семьи
        // Таким методом я создал всех основных членов - 2 бабушки, 2 дедушки, отец, мать, дочь

        FamilyMembers grandFatherOne = FamilyMembers.CreateMember(
            name: "Макаров Петр",
            gender: Gender.man,
            age: 61
            );

        FamilyMembers grandFatherTwo = FamilyMembers.CreateMember(
            name: "Беисов Нурлан",
            gender: Gender.man,
            age: 61
            );

        FamilyMembers grandMotherOne = FamilyMembers.CreateMember(
            name: "Макарова Ольга",
            gender: Gender.woman,
            age: 60
            );

        FamilyMembers grandMotherTwo = FamilyMembers.CreateMember(
            name: "Беисова Любовь",
            gender: Gender.woman,
            age: 55
            );

        FamilyMembers father = FamilyMembers.CreateMember(
            name: "Макаров Егор",
            gender: Gender.man,
            age: 32,
            mother: grandMotherOne,
            father: grandFatherOne
            );

        FamilyMembers mother = FamilyMembers.CreateMember(
            name: "Макарова Жанна",
            gender: Gender.woman,
            age: 33,
            mother: grandMotherTwo,
            father: grandFatherTwo
            );


        FamilyMembers daughter = FamilyMembers.CreateMember(
            name: "Макарова Майя",
            gender: Gender.woman,
            age: 7,
            mother: mother,
            father: father
            );

        // Присваиваю пользователям мужей/жен

        mother.Husband = father;
        father.Wife = mother;
        grandMotherOne.Husband = grandFatherOne;
        grandFatherOne.Wife = grandMotherOne;
        grandMotherTwo.Husband= grandFatherTwo;
        grandFatherTwo.Wife = grandMotherTwo;


        // Создаю массив со всеми членами семьи

        FamilyMembers[] membersArray = new FamilyMembers[] { grandFatherOne, grandFatherTwo,  grandMotherOne, grandMotherTwo, father, mother, daughter};

        // Я сделал метод для вывода в консоль данных из массива
        
        FamilyMembers.ShowInConsoleArray( membersArray, headline: "Все члены семьи" );

        // Получаем бабушек, дедушек и родителей

        var grandMothers = daughter.GetGrandMother();
        var grandFathers = daughter.GetGrandFather();
        var parents = daughter.GetParents();

        // Выводим в консоль 

        FamilyMembers.ShowInConsoleArray(grandMothers, headline: "БАБУЛИ");
        FamilyMembers.ShowInConsoleArray(grandFathers, headline: "ДЕДУЛИ");
        FamilyMembers.ShowInConsoleArray(parents, headline: "РОДИТЕЛИ");

        // Выводим в консоль всех, кто на ком женат

        for (int i = 0; i < membersArray.Length; i++)
        {
            FamilyMembers.ShowMerried(membersArray[i] );
        }
    }
}



public enum Gender { man, woman }

