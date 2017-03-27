# Abstract Factory

Creates an instance of several families of classes. Provide an interface for creating families of related or dependent objects without specifying their concrete classes.

Abstract Factory design pattern by definition says it provides an interface for creating families of related or dependent objects without specifying their concrete classes. This definition is taken from GOF (Gang of Four) Patterns. It simply gives you benefits over creating similar object by avoiding the hassle of creating concrete implementation.

Let take an example of the Car factory this will give us more idea on how the pattern works. Car factory produces hatchbacks, sedans etc. the specification for the hatchbacks and sedans is somewhat standard you have additional boot space in sedans. So whenever a company creates a hatchback or sedan they have same set of specifications for creating it. So idea behind is when you have common set of specifications you inherit that from your base model and enhance your features into it for final product.

So as a car manufacturer you need 2 specifications one for Sedan and another for Hatchback. Let’s name our car manufacturers like Ford and Maruti. Both Ford and Maruti produce sedans and hatchbacks. So producing these you need factories for them. Your factories will implement base specifications.

* Car (Base)
    * Ford (Factory)
    * Figo – Hatchback
    * Fiesta – Sedan
    * Maruti (Factory)
    * Swift– Hatchback
    * Dzire– Sedan

Let’s run down with C# code to see how this can be achieved by the abstract factory pattern.

So we have base specification which is our base car factory as an interface which has 2 methods GetSedan() and GetHactchBack() both returns interfaces which will be implemented to final factory implementation.
    
    
    public interface ICarFactory
    {
        ISedan GetSedan();
        IHatchBack GetHactchBack();
    }
    

To separate the concerns we create Hatchback interface which has a method which returns the name of the product and should be overridden according to the product which implements it.
    
    public interface IHatchBack
    {
        string Name();
    }
    
Same is followed for Sedan type of cars.
    
    
    public interface ISedan
    {
        string Name();
    }
    
Both of these interfaces are implemented on products like Figo, Swift, Fiesta and Dzire according to their type like Hatchback and Sedan.

    
    public class Figo : IHatchBack
    {
        public string Name()
        {
                return "Figo";
        }
    }

    public class Swift : IHatchBack
    {
        public string Name()
        {
                return "Swift";
        }
    }

    public class Fiesta : ISedan
    {
        public string Name()
        {
            return "Fiesta";
        }
    }
    public class Dzire : ISedan
    {
        public string Name()
        {
            return "Dzire";
        }
    }
    

Now we have a CarFactory which is our base factory. We have Products (Figo, Swift, Fiesta and Dzire) which are implementing our base product types ISedan and IHatchback. Now we need Factories to generate these products. So for that we will be creating 2 more classes as factories derived from our base ICarFactory and will be returning our products .


# Ford Factory & Maruti Factory

As you see in the below code both FordFactory and MarutiFactory are derived from ICarFactory and implemented the methods which are returning Concrete implementation of the Products. This gives us advantage when we have a group of related objects but we don’t want to restrict our concrete implementation on specific types. Like in our case Figo, Swift, Fiesta and Dzire.
    
    public class FordFactory : ICarFactory
    {
        public ISedan GetSedan()
        {
            return new Fiesta();
        }

        public IHatchBack GetHactchBack()
        {
            return new Figo();
        }
    }

    public class MarutiFactory : ICarFactory
    {
        public ISedan GetSedan()
        {
            return new Dzire();
        }

        public IHatchBack GetHactchBack()
        {
            return new Swift();
        }
    }
    

# Usage

    Now all our Design structure is complete but how we are goning use it. Let see the below code. We create objects of our Maruti and Ford Factories. We then create our products and by name property we access the members of the products.
    
    ICarFactory factory1 = new MarutiFactory();
    ICarFactory factory2 = new FordFactory();

    //Factory 1 Returns Swift
    IHatchBack SwiftObj = factory1.GetHactchBack();          
    Console.WriteLine(SwiftObj.Name());

    //Factory 1 Returns Dzire
    ISedan DzireObj = factory1.GetSedan();
    Console.WriteLine(DzireObj.Name());

    //Factory 2 Returns Figo
    IHatchBack FigoObj = factory2.GetHactchBack();
    Console.WriteLine(FigoObj.Name());

    //Factory 2 Returns Fiesta
    ISedan FiestaObj = factory2.GetSedan();
    Console.WriteLine(FiestaObj.Name());
    

The code will give us (Swift, Dzire, Figo and Fiesta).

Fig1. Abstract Factory Class Diagram

![alt text](https://github.com/tailangp/DesignPatterns/blob/master/AbstractFactory/AbstractFactory.png "Abstract Factory Class Diagram")

I hope this gives readers an idea about the pattern and possible uses of it.

Thanks for reading. 
Leave your comments & suggestions for better improvements.