public class Main {
    public static void main(String[] args){
        System.out.println("Hola Mundo");

        Car car = new Car("VED123", new Account("Vicent Estrada", "EADV990419"));
        car.passager = 4;
        car.printDataCar();
    }
}
