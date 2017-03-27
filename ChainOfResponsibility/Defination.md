# Chain Of Responsibility
Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. 
Chain the receiving objects and pass the request along the chain until an object les it.
### The classes and objects participating in this pattern are:
* Handler   (Approver) 
	>Defines an interface for handling the requests (optional) implements the successor link.
* ConcreteHandler   (StoreManager, AreaManager, CountryHead) 
	>Handles requests it is responsible for, can access its successor.If the ConcreteHandler can handle the request, it does so; otherwise it forwards the request to its successor
* Client   (ChainApp)
	>Initiates the request to a ConcreteHandler object on the chain.

#### Handler
The handler is a abstract class which takes the ConcreteHandler and sets the successive handler by property. The successor property is protected so that i should only be available to the concrete implementation of the Handler.

    public abstract class Approver
    {
        protected Approver successor { get; set; }
        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }
        public abstract void ProcessDiscountRequest(Product product);
    }

#### ConcreteHandler
Its the implemented class which inherits the Handler and overrides the method to process the request of responsibility.
    
    public class AreaManager : Approver
    {
        public override void ProcessDiscountRequest(Product product)
        {
            //If Discount id lesser than
            if (product.Discount <= 25)
            {
                product.IsDiscountApproved = true;
            }
            else
            {
                successor.ProcessDiscountRequest(product);
            }
        }
    }

 In our Use Case/Example we have taken a approver which is our abstract base class and is implemented in our concrete handlers like StoreManager, AreaManage and CountryHead. All these are overriding the Discount method on behalf of its power otherwise they move to the successor and pass on the request to be processed.
 
 Finally the usage of the pattern is done by creating objects and its sucessor and getting the discounts back.
 
    {
        Product product = new Product(50, 1500);
        Approver storeMgr = new StoreManager();
        Approver areaMgr = new AreaManager();
        Approver countryHead = new CountryHead();
        
        //Set Successor
        storeMgr.SetSuccessor(areaMgr);
        areaMgr.SetSuccessor(countryHead);
        
        //Call 1st Process Request
        storeMgr.ProcessDiscountRequest(product);
        
        //Gets the discounts 
        product.GetDiscountedPrice()
    }
 
 As you can see in above example you create objects of each of your approvers and set its successors by passing on the next level responsible object. Each approver will have the condition to check for the responsibility which in our case is amount of the discount the it can provide to the product.
 
 Finally when you call on the ProcessDiscountRequest if the condition is satisfied it process the discount or moves it to the successor.
 
 
    public class StoreManager : Approver
    {
        public override void ProcessDiscountRequest(Product product)
        {
            //If Discount Lesser than 10% 
            if(product.Discount <=  10)
            {
                product.IsDiscountApproved = true;
            }
            else
            {
                successor.ProcessDiscountRequest(product);
            }
        }
    }
           
Hope you find it useful in cases where you want to have responsibility restricted on behalf of the authority level. This pattern is also helpful in the creating a workflow or the escalation channel if you want to create.

Fig1. Chain of Responsibility Class Diagram

![alt text](https://github.com/tailangp/DesignPatterns/blob/master/ChainOfResponsibility/ChainOfResponsibility.png "Chain of Responsibility Class Diagram")

I hope this gives readers an idea about the pattern and possible uses of it.

Thanks for reading. 
Leave your comments & suggestions for better improvements.