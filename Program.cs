using hotel.models;

Suite suitePremium = new("Premium", 2, 200);
Pessoa joao = new("João", "Silva");
Pessoa paula = new("Paula", "Souza");
Pessoa paulo = new("Paulo", "Silva");
Pessoa cesar = new("César", "Augustus");
Reserva reserva = new(diasReservados: 9);
reserva.CadastrarSuite(suitePremium);
reserva.CadastrarHospede(joao);
reserva.CadastrarHospede(paula);
Console.WriteLine(reserva.CalcularValorDiaria());
