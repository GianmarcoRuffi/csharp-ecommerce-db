using System.Linq;

using (EcommerceContext db = new EcommerceContext()) 
  

{
    Products Product1 = new Products() { Name = "Arco da Caccia", Description = "Arco da caccia, utile per caccia e combattimenti a corto e medio raggio.", Price = 50 };
    Products Product2 = new Products() { Name = "LR-300", Description = "Insegui i tuoi nemici con questo potente fucile d'assalto leggero.", Price = 50 };
    Products Product3 = new Products() { Name = "Granata barattolo", Description = "Ordigno esplosivo inaffidabile.", Price = 50 };
    Products Product4 = new Products() { Name = "Fucile a doppia canna", Description = "Un fucile a due canne che consente di sparare due colpi in rapida successione prima di dover ricaricare.", Price = 50 };
    Products Product5 = new Products() { Name = "Silenziatore", Description = "Riduce significativamente il suono dello sparo.", Price = 50 };
    Products Product6 = new Products() { Name = "Fucile M39", Description = "Fucile militare semi-automatico", Price = 50 };
    Products Product7 = new Products() { Name = "Mirino ottico", Description = "Un mirino ottico con una lente che ingrandisce di 8 volte la mira.", Price = 50 };
    Products Product8 = new Products() { Name = "MP5A4", Description = "Una mitragliatrice di medio danno.", Price = 50 };
    Products Product9 = new Products() { Name = "M249", Description = "Mitragliatrice con danno elevato, alta cadenza di tiro, caricato da cartucciera.", Price = 50 };
    Products Product10 = new Products() { Name = "Lanciagranate multiplo", Description = "Un lanciagranate semiautomatico a sei cilindri da 40 mm", Price = 50 };

    db.Products.Add(Product1);
    db.Products.Add(Product2);
    db.Products.Add(Product3);
    db.Products.Add(Product4);
    db.Products.Add(Product5);
    db.Products.Add(Product6);
    db.Products.Add(Product7);
    db.Products.Add(Product8);
    db.Products.Add(Product9);
    db.Products.Add(Product10);
    db.SaveChanges();


    //Read
    Console.WriteLine("Recupero lista di Prodotti");
    List<Products> products = db.Products.ToList();


}









