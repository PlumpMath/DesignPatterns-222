# Singleton

A class of which only a single instance can exist. Ensure a class has only one instance and provide a global point of access to it.

Singleton design pattern provides application to use single object and provides re usability of object within application. Singleton pattern instantiates a single instance of the object of itself and provides access to it from an inline declared property. It restricts creation of objects so needs to have a private constructor.

We will be using Logger as an example as it can be considered as best candidate in application to be used for logging.

Singleton can be implemented in various forms. We will discuss about 3 in details.

* Lazy or Instance Singleton.
* Static Singleton.
* Multi threaded Singleton.

## Lazy or Instance Singleton

	public class LoggerSingleton
    {
        private static LoggerSingleton loggerInstance

        private LoggerSingleton()
        {

        }

        public static LoggerSingleton LoggerInstance
        {
            get
            {
                if(loggerInstance==null)
                {
                    loggerInstance=new LoggerSingleton();
                }
                return loggerInstance;
            }
        }
    }

###### The above example is done in 3 steps:
* 1st step is to create a private static member of the Singleton class which will serve us an instance of the singleton class.
* 2nd step is to create private constructor to avoid or restrict object instantiation.
* 3rd and final step is to create public static property which returns the private static member.

So now we are able to create the Lazy Singleton, let’s think of the pros and cons of this implementation.

The main advantage of this implementation is that its lazy in nature as the instance is only created when needed. Another one is that this Class can be further inherited to a child and child can be instantiated.

Major disadvantage of this implementation is it threads safety issue. 2 or more concurrent threads can instantiate the object of the Singleton and the purpose will not suffice. That's why it’s not suited for Multi-threaded environments.

## Static Singleton

    public sealed class LoggerSingleton
    {
        private static readonly LoggerSingleton loggerInstance = new LoggerSingleton();

        private LoggerSingleton() { }

        public static LoggerSingleton LoggerInstance
        {
            get
            {
                return loggerInstance;
            }
        }
    }

###### The above implementation can be achieved in 4 steps :
* 1st step is to create a sealed class to avoid inheritance.
* 2nd step is to create a private static read only member of the Singleton class which will serve us an instance of the singleton class. As its read only it needs to be initialized at the start.
* 3rd step is to create private constructor to avoid or restrict object instantiation.
* 4th and final step is to create public static property which returns the private static read only member.

This implementation strategy helps in achieving singleton but with the help of language runtime. All the instantiation logic is handled by runtime and user has no option to override the instantiation process. 

## Multi-threaded Singleton

    public sealed class LoggerSingleton
    {
        private static volatile LoggerSingleton loggerInstance;
        private static object obj = new Object();

        private LoggerSingleton() { }

        public static LoggerSingleton Instance
        {
            get
            {
                if (loggerInstance == null)
                {
                    lock (obj)
                    {
                        if (loggerInstance == null)
                            loggerInstance = new LoggerSingleton();
                    }
                }
                    return loggerInstance;
            }
        }
    }


###### The above implementation can be achieved in below given steps :
* Create a sealed class to avoid inheritance.
* Create a private static volatile member of the Singleton class which will serve us an instance of the singleton class. The volatile keyword in C# tells the runtime that this object will be accessed by multiple threads.
* Create a private static object which is instantiated as Object Type. This object will help us in creating a lock.
* Create a private constructor to avoid or restrict object instantiation.
* Create public static property which returns the private static read only member. This property will do double checking of the our singleton object comparing it to null as well as keep the lock on volatile. 
* The lock keyword marks the statement block as critical section by obtaining mutual exclusion. In our implementation it’s the inner null checking of the instance object.

This implementation strategy helps in achieving singleton with the help of language runtime as well give us benefit to control the instantiation of the our Singleton by doing double checking mechanism for creating a single instance. It supports multi threaded environments due to use of volatile keyword and acquiring lock over a section of code to avoid separate thread to wait till the instance is created.

So this comes to an end on the singletons primer. We can have more implementations of the pattern. As per what implementation to use i can say it depends on the architecture of the project if you are using single threaded application then you can go ahead with the 1st one, if you want to leverage runtime features within single thread go with 2nd one but if you want to extend your implementation to multi-threaded application using runtime features go with the 3rd on.

I hope this gives readers an idea about the pattern and possible uses of it.

Thanks for reading. 
Leave your comments & suggestions for better improvements.