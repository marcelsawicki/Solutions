import java.util.Scanner;
 
interface iWork 
{
	public void pracuj();
}
 
interface iArrive 
{
	public void dojezdzaj();
}
 
interface iFreeTime
{
	public void spedzajWolnyCzas();
}
 
//poszczegolne algorytmy
class NaprawaSamochodow implements iWork 
{
	public void pracuj()
	{
		System.out.println("Praca: naprawia samochody");
	}
}
 
class Leczenie implements iWork 
{
	public void pracuj()
	{
		System.out.println("Praca: leczy ludzi");
	}
}
 
class RoznoszenieListow implements iWork 
{
	public void pracuj()
	{
		System.out.println("Praca: roznosi listy");
	}
}
 
class Samochod implements iArrive 
{
	public void dojezdzaj()
	{
		System.out.println("Dojazd: samochod");
	}
}
 
class Rower implements iArrive 
{
	public void dojezdzaj()
	{
		System.out.println("Dojazd: rower");
	}
}
 
class Silownia implements iFreeTime 
{
	public void spedzajWolnyCzas()
	{
		System.out.println("Wolny Czas: silownia");
	}
}
 
class LiteraturaPopularnoNaukowa implements iFreeTime 
{
	public void spedzajWolnyCzas()
	{
		System.out.println("Wolny Czas: literatura popularno-naukowa");
	}
}
 
//context
class Worker {
	private iWork work = null;
	private iArrive dojezdzac = null;
	private iFreeTime spedzanieWolnegoCzasu = null;
	 
	public Worker(String zawod){
		if(zawod.equalsIgnoreCase("mechanic"))
		{
			work = new NaprawaSamochodow();
			dojezdzac = new Samochod();
			spedzanieWolnegoCzasu = new Silownia();
		}
		else if(zawod.equalsIgnoreCase("doctor"))
		{
			work = new Leczenie();
			dojezdzac = new Samochod();
			spedzanieWolnegoCzasu = new LiteraturaPopularnoNaukowa();
		}
		else if(zawod.equalsIgnoreCase("postman"))
		{
			work = new RoznoszenieListow();
			dojezdzac = new Rower();
			spedzanieWolnegoCzasu = new Silownia();
		}
	 
	}
	 
	//tutaj wywolujemy algorytmy
	public void methods()
	{
		work.pracuj();
		dojezdzac.dojezdzaj();
		spedzanieWolnegoCzasu.spedzajWolnyCzas();
	}
	 
	public static void main(String[]args)
	{
		System.out.println("Please type occupation (mechanic, doctor, postman):");
		Scanner in = new Scanner(System.in);
		String occupation = in.nextLine();
		 
		try 
		{
			Worker worker = new Worker(occupation);
			worker.methods();
		}
		catch(Exception e)
		{
			System.out.println("we do not have this profession");
		}
	}
}