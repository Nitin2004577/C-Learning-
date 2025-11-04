//Create a List<string> containing the name of 3 of your favourite fruits

List<string> favFruits = new List<string>(){"apple", "banana", "Mango"};

//adding a new fruit to the list
favFruits.Add("Papaya");

//remove one fruit from the list
favFruits.Remove("banana");

//printig all the fruits using a foreach loop
foreach (string favFruit in favFruits)
{
    System.Console.WriteLine(favFruit);
}

//creating a dictionary<int, string>
Dictionary<int, string> fruits = new Dictionary<int, string>()
{
    { 1, "apple" },
    { 2, "banana" }
};
//adding a new entry to the dictionary
fruits.Add(3, "peach");

//printing all the key value pairs
foreach (KeyValuePair<int, string> fruit in fruits)
{
    System.Console.WriteLine($"Key: {fruit.Key}, Name: {fruit.Value}");
}