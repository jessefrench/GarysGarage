using Garage;

Zero fxs = new Zero() 
{ 
    MainColor = "red",
    MaximumOccupancy = 1,
};

Tesla modelS = new Tesla()
{
    MainColor = "white",
    MaximumOccupancy = 4,
};

Cessna mx410 = new Cessna()
{
    MainColor = "grey",
    MaximumOccupancy = 2,
};

Ram r1500 = new Ram()
{
    MainColor = "black",
    MaximumOccupancy = 4,
};

fxs.Drive();
fxs.Turn();
fxs.Stop();
modelS.Turn();
modelS.Stop();
modelS.Drive();
mx410.Drive();
mx410.Turn();
mx410.Stop();
r1500.Drive();
r1500.Turn();
r1500.Stop();