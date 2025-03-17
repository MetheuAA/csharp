﻿using POO.model;

Veiculo obj = new Veiculo("Honda", "Civic", 2020, 240.00);
obj.Acelerar();
obj.Freiar();

Moto moto = new Moto("Yamaha", "YZF-R6", 2022, 0.0, true, true);
moto.Empinar();

Carro carro = new Carro("Chevrolet", "Corvette", 2021, 0.0, true, 2);
carro.AbrirPortas();