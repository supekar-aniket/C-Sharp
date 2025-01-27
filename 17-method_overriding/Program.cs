using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            method overriding : 
                        - same method name,same parameters,same return type.
                        - we can Customizes or extends the behavior of a parent class's method.
                        - all methods in different class.
                        - Cannot reduce visibility compared to the parent method.
                            Ex : - If the method in the parent class is public, the overridden method in the subclass must also be public.
                                - Changing it to protected or private would result in an error.
                        - each method is in the different class.
            */

             Dog dog = new Dog();
             Cat cat = new Cat();

             dog.Speak();
             cat.Speak();   
            
        }

        class Animal {
            public virtual void Speak(){
                System.Console.WriteLine("The Animal goes *brrr*");
            }
        }

        class Dog : Animal {
            
            public override void Speak(){
                System.Console.WriteLine("The Dog goes *woof*");
            }
        }

        class Cat : Animal {

            public override void Speak()
            {
                System.Console.WriteLine("The Cat goes *Meow*");
            }
        }
    }
}