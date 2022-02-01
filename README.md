# The Ready App

A notification messaging platform mobile application for android (currently) allowing businesses and entrepreneurs to notify a user when a product/service is complete or ready.

Sellers will anonymously be able to do business with a seller without having a feeling that thier patential consumer will be side tracked and buy from another seller.

Buyers will be able to notify the buyer of a product/service he/her desire,
and seller will notify the buyer when that service/product is complete or ready.


> ***NOTE***: This project is merely to demostrate skills and deducation. I'm willing to take this product as far as I can.


## Available Links

Think of this as a place of understanding.


[Models](https://github.com/Tooensure-OpenSource/com.tooensure.readyapp/tree/master/ReadyApp/ReadyApp/Models)

Models combines the fields and methods(member function which defines actions) into a single unit. In C#, classes support polymorphism, inheritance and also provide the concept of derived classes and base classes.



[Services](https://github.com/Tooensure-OpenSource/com.tooensure.readyapp/tree/master/ReadyApp/ReadyApp/Services)

Ready App services uses dependency injection as code logic reuse. Everytime a service is called based on your device (android or Ios), the dependency service will call. 



[Android Dependency Services](https://github.com/Tooensure-OpenSource/com.tooensure.readyapp/tree/master/ReadyApp/ReadyApp.Android/Dependencies)

Nicely put, Services are pretty much platform pacific. This means dependency on platform.
CSharp interfaces can still be used (It's still CSharp I'm writing). Just don't forget to derive from `Java.Lang.Object`. This namespace allows me & you to write Java (that's our pacific platform, we're implementing).

> Thinking about adding the generic abstrach class here to, but not really needed, maybe a dependency of work mite help.



[Types](https://github.com/Tooensure-OpenSource/com.tooensure.readyapp/tree/master/ReadyApp/ReadyApp/Types)

You'll notice Ready App taking advantage of enum types throughtout the application. This is because we fill that string are more useful in a user input, collect data type of case. Enmun types are very satisfying. 


[ViewModel](https://github.com/Tooensure-OpenSource/com.tooensure.readyapp/tree/master/ReadyApp/ReadyApp/ViewModels)

Veiw model is a nice patteren to seperate the UI from the businesses logic.
Find alot of my problem solving here. I'm  trying to make delegate call to trigger authentication type.



[Views](https://github.com/Tooensure-OpenSource/com.tooensure.readyapp/tree/master/ReadyApp/ReadyApp/Views)

Now there's some heavy animation within AuthPage code behind file.
Other views as well as it's struture