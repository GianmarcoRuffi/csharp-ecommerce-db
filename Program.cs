using System.Linq;

static void Main() {}


using (EcommerceContext db = new EcommerceContext())
{
    // Create
    Products newProduct = new Products { Name = "Fucile LR300", Description = "Stalkera i tuoi avversari con questo fucile di grado militare.", Price = 900 };
    db.Add(newProduct);
    db.SaveChanges();
    // Read
    Console.WriteLine("Recupero lista di Prodotti");
    List<Products> products = db.Products.OrderBy(products => products.Name).ToList();
}




