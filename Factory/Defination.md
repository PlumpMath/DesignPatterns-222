# Factory

Creates an instance of several derived classes. In Factory pattern, we create object without exposing the creation logic to the client and refer to newly created object using a common interface or class.

Factory design pattern by definition says it provides an interface for creating families of related or dependent objects without specifying their concrete classes. This definition is taken from GOF (Gang of Four) Patterns. It simply gives you benefits over creating similar object by avoiding the hassle of creating concrete implementation.

Let take an example of the Position factory this will give us more idea on how the pattern works. Position factory produces Manager, Developer etc. the specification for the Manager and Developer is somewhat same you have Title associated to it which tells its name. So whenever Position Factory creates a Developer or Manager they have same set of specifications for creating it. So idea behind is when you have common set of specifications you inherit that from your base model and enhance your features into it for final objects.

So in our example we have 
* PositionFactory (Creator)
* Position (Base Class or Interface having specifications)
* Manager and Developer (Concrete Implementation of the Base Class)


#### Position 
The position class is our base class which is abstract or interface which will have common specification like the title property. The Title property will be overridden in the child classes to get the specification overridden as per need.

    public abstract class Position
    {
        public abstract string Title { get;}
    }

#### Position Factory 
The PositionFactory class is our factory class which is static and looks for a condition and returns the concrete object.

    public static class PositionFactory
    {
        public static Position Get(int type)
        {
            switch (type)
            {
                case 0:
                    return new Manager();
                case 1:
                    return new Developer(); 
                default:
                    return null;
            }
        }
    }

#### Manage and Developer (Concrete Classes) 
The Developer and Manager classes will be overriding the Title and provides their own implementation which in our example is the title only from the base class Position.

    public class Developer : Position
    {
        public override string Title
        {
            get
            {
                return "Developer";
            }
        }
    }

#### Usage
When ever you want you can call the Get method passing the required parameter in our case 1 for developer, 0 for manager else it will be null if the condition is not matched. The Factory will give you the desired object.
    {
        var developer = PositionFactory.Get(1);
        Assert.IsNotNull(developer);
        Assert.IsInstanceOfType(developer, typeof(Position));
    }


In the above example you can see when ever you want to centralized the logic of creating the concrete object you can use this pattern,, possible use cases are Database connection etc.

Fig1. Factory Pattern Class Diagram

![alt text](https://github.com/tailangp/DesignPatterns/blob/master/Factory/Factory.png "Factory Pattern Class Diagram")

I hope this gives readers an idea about the pattern and possible uses of it.

Thanks for reading. 
Leave your comments & suggestions for better improvements.