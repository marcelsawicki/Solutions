
public class OffRadioState implements iRadioState 
{
	public void execute(Radio radio)
	{
		System.out.println("Radio off");
		radio.setOn(false);
	}
}
