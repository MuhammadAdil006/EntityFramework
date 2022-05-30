
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;
using EntityFRAMEWORK;
//install Microsoft.EntityFramework Core
//install Microsoft.EntityFrameworksqlserver
//install Microsoft.EntityFrameworktools

//create and design db then add Scaffold-DbContext 'Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Chinook' Microsoft.EntityFrameworkCore.SqlServer
//you can find reverse enginerring core on internet
public class Program {
    public static void Main(string[] args)
    {

        var Context = new testingContext();
        //Product product = new Product();
        //product.Name = "Mobile";
        //product.Id = 1;
        //Context.Products.Add(product);
        //Context.SaveChanges();

        //update and retrieve
        //var pro = Context.Products.First();
        //pro.Name = "phone";
        //Context.SaveChanges();

        //delete

        //where returns more than so if you want to take only first
         Product pro =(Product) Context.Products.Where(pr=>pr.Id==1).FirstOrDefault();
        
        Context.Products.Remove(pro);
        Context.SaveChanges();

    }
}
