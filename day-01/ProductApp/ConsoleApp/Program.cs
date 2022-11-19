var productList = new List<string>();
productList.Add("Bilgisayar");
productList.Add("Telefon");
productList.Add("Table");

foreach (var prd in productList)
{
    Console.WriteLine(prd);
}

Console.WriteLine();

productList.ForEach(prd =>
    Console.WriteLine(prd));


Console.ReadKey();
