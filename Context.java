package src;

public class Context {
	private AreaCalculator calculator;
	
	public Context(AreaCalculator calculator){
		this.calculator = calculator;
	}
	
	public double executeAreaCalculation(int num1, int num2){
		return calculator.calculate(num1, num2);
	}

}
