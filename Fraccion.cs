class Fraccion{
    int numerador;
    int denominador;
    public Fraccion(int n, int d){
        numerador=n;
        denominador=d;
         if(d==0){
        throw new Exception("ERROR: el denominador no puede ser cero");
    }
    }
   
    public static Fraccion operator+(Fraccion f) => f;
    public static Fraccion operator -(Fraccion f)=>new Fraccion(-f.numerador, f.denominador);
    public static Fraccion operator +(Fraccion f1, Fraccion f2)
    => new Fraccion(f1.numerador * f2.denominador + f2.numerador * f1.denominador, f1.denominador * f2.denominador);
    public static Fraccion operator -(Fraccion f1, Fraccion f2)=> f1 +(-f2);
    public override string ToString()
    {
        return $"{numerador.ToString()}/{denominador.ToString()}";
    }
}