
public class OnRadioState implements iRadioState
{
	public void execute(Radio radio)
	{
		System.out.println("Radio on");
		radio.setOn(true);
	}
}
