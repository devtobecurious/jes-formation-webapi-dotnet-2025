using DiscoverEvents;

FireMan fireMan = new();
Ambulance ambulance = new();

using CallingCenter callingCenter = new();


//callingCenter.FireOccuring += fireMan.PutWaterOnFire;
//callingCenter.FireOccuring += ambulance.CallWithBigCar;
//callingCenter.FireOccuring += ambulance.CallWithBigCar;

//callingCenter.FireOccuring += (address, severity) =>
//{
//	Console.WriteLine("Hey peu cher ! vos papiers siouplé");
//};

callingCenter.Subscribe(fireMan.PutWaterOnFire);

callingCenter.Call(new(), Severity.Urgent);

//callingCenter.FireOccuring -= fireMan.PutWaterOnFire;
//callingCenter.FireOccuring -= ambulance.CallWithBigCar;
//callingCenter.FireOccuring -= ambulance.CallWithBigCar;

Console.WriteLine("------------------");
callingCenter.Call(new(), Severity.Urgent);


