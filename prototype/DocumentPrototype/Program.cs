namespace DocumentPrototype;

public class Program
{
    public static void Main()
    {
        Document original = new Document(1, "Hisobot", "Oylik hisobot matni", "Ali Valiyev",
            new List<string> { "hisobot", "oylik" });

        DocumentFactory factory = new DocumentFactory(original);

        Document copy1 = factory.CloneDocument();
        Document copy2 = factory.CloneDocument();

        copy1.Id = 2;
        copy1.Title = "Shartnoma";
        copy1.Content = "Shartnoma matni";
        copy1.Tags.Add("yuridik");

        copy2.Id = 3;
        copy2.Title = "Taklifnoma";
        copy2.Content = "Taklifnoma matni";
        copy2.Tags[0] = "taklif";

        Console.WriteLine("=== Deep Copy (Clone) ===");
        Console.WriteLine("Original: " + original);
        Console.WriteLine("Copy 1:   " + copy1);
        Console.WriteLine("Copy 2:   " + copy2);
        Console.WriteLine($"original == copy1: {ReferenceEquals(original, copy1)}");
        Console.WriteLine($"Tags ro'yxati umumiymi: {ReferenceEquals(original.Tags, copy1.Tags)}");
        Console.WriteLine();

        // Taqqoslash: Shallow Copy da tegni o'zgartirish originalga ham ta'sir qiladi
        Console.WriteLine("=== Shallow Copy (taqqoslash uchun) ===");
        Document shallow = original.ShallowClone();
        shallow.Title = "Shallow nusxa";
        shallow.Tags.Add("XATO");
        Console.WriteLine("Original: " + original);
        Console.WriteLine("Shallow:  " + shallow);
        Console.WriteLine($"Tags ro'yxati umumiymi: {ReferenceEquals(original.Tags, shallow.Tags)}");
    }
}
