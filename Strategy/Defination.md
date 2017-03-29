# Strategy
>Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from the clients that use it.
>Capture the abstraction in an interface, bury implementation details in derived classes.
In Startegy Pattern, behavior of the class can be changed at runtime.

#### Problem
Applications tend to have high level of coupling which makes them less maintainble and tested independently.
Which in sense breaks the "Open Closed principle". The "Open Closed principle" says classes should be open for extension but closed for modifications as it will help break less test and application modules.
So to solve the problem we need to put our focus on Cohesion and make our application classes losely coupled. 
Creates an instance of several families of classes. Provide an interface for creating families of related or dependent objects without specifying their concrete classes.

Let take an example of the Tax on product and how we can get the tax rate for a particular product. So for each of the products we have different types of taxes imposed and can have different amount of rates invloved.
So if you apporach the problem you will find out that you can simply say. Create a base class for tax inherit tax class in various other tax classes and use a common method to ccalculate the tax. This seems to be a solution to the problem but if you have diffrent tax rates you will always have problems and if you change it it will reflect in all the child classes.

To overcome the problem with inheritance we can use loose coupling and cohesion and create a interface which will have a common method to return rate for a price provided. Moreover we will be overridding this method in the sub tax classes and provide a different tax rate for each of the sub class.
While creating instances to calculate the tax we will create objects from base class and pass on the desired child classes object at runtime.

#### Lets look into the code
* IProductTax (Base Interface)
    * DirectTax (Child Class Implementing Base Interface)
    * InDirectTax – (Child Class Implementing Base Interface)
    * ValueAddedTax – (Child Class Implementing Base Interface)
    * Product (Concrete class used for runtime assignment of the child class and providing common method to return result)

Let’s run down with C# code to see how this can be achieved by the strategy pattern.

#### Base interface 
    
    public interface IProductTax
    {
        double GetProductTax(int price);
    }

#### Child classes implementing the IProductTax its own Tax Rate.
    
    public class DirectTax : IProductTax
    {
        private const double _directTaxRate = 10;
        public double GetProductTax(int price)
        {
            return ((_directTaxRate / 100) * price);
        }
    }


    public class InDirectTax : IProductTax
    {
        private const double _inDirectTaxRate = 2.5;
        public double GetProductTax(int price)
        {
            return ((_inDirectTaxRate / 100) * price);
        }
    }

    public class ValueAddedTax : IProductTax
    {
        private const double _valueAddedTax = 5;
        public double GetProductTax(int price)
        {
            return ((_valueAddedTax / 100) * price);
        }
    }

#### Finally the class which will set the runtime behavior. 
It will have a constructor setting the runtime object and using the desired object to call the method.

    public class Product
    {
        private IProductTax _productTax;
        public Product(IProductTax productTax)
        {
            this._productTax = productTax;
        }
        public double GetTax(int price)
        {
            return this._productTax.GetProductTax(price);
        }
    }

#### Usage

    public void TestStrategyValueAddedTax()
    {
        IProductTax productTax = new ValueAddedTax();
        Product product = new Product(productTax);
        const int price = 100;
        const double taxRate = 5;
        //Get Price with Value Added Tax
        Assert.AreEqual(product.GetTax(price), ((taxRate / 100) * price));
    }

By above example you can see how you can isolate the logic and make your modules independent. This is called abstract coupling which is derived from OO principle "Program to an interface, not an implementation".

Fig1. Strategy Class Diagram

![alt text](https://github.com/tailangp/DesignPatterns/blob/master/Strategy/Strategy.png "Strategy Class Diagram")

I hope this gives readers an idea about the pattern and possible uses of it.

Thanks for reading. 
Leave your comments & suggestions for better improvements.
