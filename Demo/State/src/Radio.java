
public class Radio {
	private boolean on;
	private iRadioState state;
	
	public Radio(iRadioState state) 
	{
		this.state = state;
	}
	
	public void execute()
	{
		state.execute(this);
	}
	
	public void setState(iRadioState state) 
	{
		this.state = state;
	}
	
	public void setOn(boolean on)
	{
		this.on = on;
	}
	
	public boolean isOn()
	{
		return on;
	}
	
	public boolean isOff()
	{
		return !on;
	}
	
}
