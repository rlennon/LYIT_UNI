package src;

import java.util.Scanner;

public class Menu {

	public static void main(String[] args) {
		int height;
		int width;
		String shape;
		int type = 0;
		
		char tryagain = 'y';

		Scanner input = new Scanner(System.in);
		while (tryagain == 'y') {
			int isshape = 0;
			System.out.println("######################################");
			System.out.println("## Welcome to the Area Calculator   ##");
			System.out.println("###### Please enter a shape!   #######");
			System.out.println("######################################");
			while (isshape == 0) {

				shape = input.next();
				if (shape.equals("Triangle") || shape.equals("triangle")) {
					type = 1;
					isshape = 1;
				} else if (shape.equals("Rectangle") || shape.equals("rectangle")) {
					type = 2;
					isshape = 1;
				} else {
					isshape = 0;
					System.out.println("Shape not supported, Please try again");
				}

			}
			System.out.println("Enter the height of the shape");
			height = input.nextInt();
			System.out.println("Enter the height of the shape");
			width = input.nextInt();

			switch (type) {
			case 1:
				Context triangle = new Context(new Triangle());
				System.out.println("Area = " + triangle.executeAreaCalculation(height, width));
				break;
			case 2:
				Context rectangle = new Context(new Rectangle());
				System.out.println("Area = " + rectangle.executeAreaCalculation(height, width));

			}
			System.out.println("Do you wish to calculate the area of another shape [y/n]");
			if (input.next().equals("y")) {
				tryagain = 'y';
			} else {tryagain = 'n';}

		}

	}

}
