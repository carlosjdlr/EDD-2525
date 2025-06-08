using System;

// Clase para representar un círculo
public class Circulo
{
    // Atributo privado que almacena el radio del círculo
    private double radio;

    // Constructor que recibe el valor del radio
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Método para calcular el área del círculo
    // Fórmula: π * radio^2
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // Método para calcular el perímetro del círculo
    // Fórmula: 2 * π * radio
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// Clase para representar un rectángulo
public class Rectangulo
{
    // Atributos privados para base y altura
    private double baseRectangulo;
    private double altura;

    // Constructor que recibe la base y altura del rectángulo
    public Rectangulo(double baseRectangulo, double altura)
    {
        this.baseRectangulo = baseRectangulo;
        this.altura = altura;
    }

    // Método para calcular el área del rectángulo
    // Fórmula: base * altura
    public double CalcularArea()
    {
        return baseRectangulo * altura;
    }

    // Método para calcular el perímetro del rectángulo
    // Fórmula: 2 * (base + altura)
    public double CalcularPerimetro()
    {
        return 2 * (baseRectangulo + altura);
    }
}
