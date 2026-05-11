using Am.ApplicationCore.Domaine;

//Default Constructor
//Plane plane = new Plane();
//plane.Capacity = 200;
//plane.ManufactureDate = new DateTime(2010, 5, 1);
//plane.PlaneType = PlaneType.Boeing;

////Paremeterized Constructor
//Plane plane2 = new Plane(15, new DateTime(2000, 02, 09), PlaneType.Concorde);

//Object Initializer 
Plane plane3 = new Plane{
    Capacity = 300,
    ManufactureDate = new DateTime(2015, 10, 20),
    PlaneType = PlaneType.Airbus
};
Passenger passenger = new Passenger { 
    BirthDate = new DateTime(1995, 12, 15),
    FirstName = "Mahdi",
    LastName = "Masmoudi",
    EmailAddress = "mahdimasmoudi@gmail.com"
    
};
Staff staff = new Staff();
Traveller traveller = new Traveller();

Console.WriteLine(passenger.CheckProfile("Mahdi", "Masmoudi"));
Console.WriteLine(passenger.CheckProfile("Mahdi", "Masmoudi", "mahdimasmoudi@gmail.comm"));
Console.WriteLine(passenger.CheckProfile3("Mahdi", "Masmoudi"));
passenger.passengerType();
Console.WriteLine("*****************");
staff.passengerType();
Console.WriteLine("*****************");
traveller.passengerType();

