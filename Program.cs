Console.Clear();
bool playing = true;

while(playing == true)
{
playing = true;

Console.WriteLine("Hey man what's your name.");
string name = Console.ReadLine();

Console.WriteLine($"alright that's cool bro see you later {name} .");

bool yessir = true;
Console.WriteLine($"so uh {name} want me to say all that then just type in yes or no if you want to leave me how sad.");
string responce = Console.ReadLine();
while(yessir == true)
{
Console.WriteLine($"so like i need a yes or no not this \"{responce}\" ");
responce = Console.ReadLine();
responce.ToLower();
if(responce == "yes" ){
yessir = false;
playing = true;
}else if(responce == "no" ){
yessir = false;
playing = false;
}
}
}