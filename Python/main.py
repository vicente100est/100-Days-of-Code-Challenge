from Car import Car
from account import Account

if __name__ == "__main__":
    print("Hola Mundo")

    car = Car("VED123", Account("Vicente Estrada", "EADV990419"))
    print(vars(car))
    print(vars(car.driver))