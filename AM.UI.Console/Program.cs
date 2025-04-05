// See https://aka.ms/new-console-template for more information

using AM.Core.Domain;
using AM.Data;


Plane myPlane = new Plane();
myPlane.Capacity = 28;
myPlane.ManufactureDate = DateTime.Now;
myPlane.MyPlaneType=PlaneType.Airbus;

Plane myPlane2 = new Plane(PlaneType.Boing,71,DateTime.Now);

Plane myPlane3 = new Plane()
{
    Capacity = 23,
    ManufactureDate = DateTime.Now,
    MyPlaneType = PlaneType.Airbus,
};

Passenger myPassenger = new Passenger();
Staff myStaff = new Staff();
Traveller myTraveller = new Traveller();
Console.WriteLine(myPassenger.GetPassengerType());
Console.WriteLine(myStaff.GetPassengerType());
Console.WriteLine(myTraveller.GetPassengerType());
Passenger aPassenger = new Passenger()
{
    BirthDate = new DateTime(2000, 01, 01)
};
aPassenger.GetAge(aPassenger);
Console.WriteLine(aPassenger.Age);
DateTime date = new DateTime(2000,01,01);
int a = 0;
aPassenger.GetAge(date, ref a );
Console.WriteLine(a);

var reservation = new Reservation
{
    Price = 100,
    Seat = "test",
    VIP = "test",
    PassengerId = 1,
    FlightId = 1
};
Console.WriteLine(reservation);
var context = new AMContext();

var plane = new Plane { Capacity = 100, ManufactureDate = DateTime.Now, MyPlaneType = PlaneType.Airbus };
var flight = new Flight { Destination = "Paris", FlightDate = DateTime.Now.AddDays(1),
    Departure="Test", Comment="Test", Comment2="Test", MyPlane = plane };

context.Flights.Add(flight);
context.SaveChanges();

Console.WriteLine(flight);
Console.WriteLine(flight.MyPlane);

var flightFromDb = context.Flights.First();
Console.WriteLine(flightFromDb);
Console.WriteLine(flightFromDb.MyPlane); // This might be null if LazyLoading is not enabled


