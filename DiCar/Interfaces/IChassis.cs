namespace DiCar.Interfaces
{
	public interface IChassis
	{
		IEngine Engine { get; }
		IBodywork Bodywork { get; }
	}
}