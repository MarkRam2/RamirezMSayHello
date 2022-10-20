// Mark Ramirez
// 10/18/2022
// say hello
// this askes your name and that's pretty much it
string name = "";

Console.Clear();
int idk = 0;

bool playing = true;
while(playing == true)
{
playing = true;

bool validation = true;
while(validation == true){
Console.WriteLine("Hey man what's your name.");
name = Console.ReadLine();

    bool NuM1 = Int32.TryParse(name, out idk);
    if(NuM1 == false ){
        validation = false;
    }else if(NuM1 == true){
    }
}


Console.WriteLine($"alright that's cool bro see you later {name} .");

bool yessir = true;
Console.WriteLine($"so uh {name} want me to say all that then just type in yes or no if you want to leave me how sad.");
string responce = Console.ReadLine();
while(yessir == true)
{
responce.ToLower();
if(responce == "yes" ){
yessir = false;
playing = true;
}else if(responce == "no" ){
yessir = false;
playing = false;
}else{
Console.WriteLine($"so like i need a yes or no not this \"{responce}\" ");
responce = Console.ReadLine();
}
}
}