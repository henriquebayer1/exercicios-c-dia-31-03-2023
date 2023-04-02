// EXERCICIO 1 -

// Console.WriteLine($"Escreva o dia de seu nascimento:");
// int dia = int.Parse(Console.ReadLine());

// Console.WriteLine($"Escreva o mes de seu nascimento:");
// int mes = int.Parse(Console.ReadLine());

// Console.WriteLine($"Escreva o ano de seu nascimento:");
// int ano = int.Parse(Console.ReadLine());

// if(dia > 31)
// {Console.WriteLine($"data invalida por numeros errados");
// }
// else if (mes > 12)
// {Console.WriteLine($"data invalida por numeros errados");
// }
// else if(ano > 2013)
// {Console.WriteLine($"data invalida por numeros errados");
// }
// else {Console.WriteLine($"Data valida");
// }

// int hora = data1.Hour;
// int dia = data1.Day;
// int mes = data1.Month;
// int ano = data1.Year;



// EXERCICIO 2 -

// Console.WriteLine($"Digite o numero 1 para analise no sistema");
// float numeroAnalise1 = float.Parse(Console.ReadLine());

// Console.WriteLine($"Digite o numero 2 para analise no sistema");
// float numeroAnalise2 = float.Parse(Console.ReadLine());

// Console.WriteLine($"Digite o numero 3 para analise no sistema");
// float numeroAnalise3 = float.Parse(Console.ReadLine());

// if(numeroAnalise1 > numeroAnalise2 && numeroAnalise1 > numeroAnalise3)
// {System.Console.WriteLine($"{numeroAnalise1} e o maior numero e o menor e o {numeroAnalise3}");}
// else if(numeroAnalise1 < numeroAnalise2 && numeroAnalise1 < numeroAnalise3)
// {Console.WriteLine($"{numeroAnalise1} e o menor numero e o maior e o {numeroAnalise3}");
// }
// else if(numeroAnalise2 > numeroAnalise1 && numeroAnalise2 > numeroAnalise3)
// {Console.WriteLine($"{numeroAnalise1} e o maior numero e o menor e o {numeroAnalise3}");
// }
// else if(numeroAnalise2 < numeroAnalise1 && numeroAnalise2 < numeroAnalise3)
// {Console.WriteLine($"{numeroAnalise1} e o menor numero e o maior e o numero {numeroAnalise3}");
// }
// else if(numeroAnalise3 > numeroAnalise2 && numeroAnalise3 > numeroAnalise1)
// {Console.WriteLine($"{numeroAnalise1} e o maior numero e o menor e {numeroAnalise1}");
// }
// else if(numeroAnalise3 < numeroAnalise2 && numeroAnalise3 < numeroAnalise1)
// {Console.WriteLine($"{numeroAnalise1} e o menor numero e o maior e {numeroAnalise1}");
// }








// EXERCICIO 3 -

// Console.WriteLine($"Informe o raio da circunferencia do circulo:");
// double raio = float.Parse(Console.ReadLine());

// double diametro = (2 * raio);
// double comprimento = (2 * Math.PI * Math.Pow(raio, 2));
// double areaDaCircunferencia = (Math.PI * Math.Pow(raio, 2));

// Console.WriteLine($"O seu diametro e de: {Math.Round(diametro,2)} o seu comprimento e de: {Math.Round(comprimento,2)} e sua area da circunferencia e de: {Math.Round(areaDaCircunferencia,2)}");












// EXERCICIO 4 -


// int sim = 0;
// int nao = 0;

// Console.WriteLine($"Reponda as seguintes perguntas com s (sim) ou n (nao):");


// Console.WriteLine($"Telefonou para a vítima?");
// string R1 = Console.ReadLine().ToLower();

// Console.WriteLine($"Esteve no local do crime?");
// string R2 = Console.ReadLine().ToLower();

// Console.WriteLine($"Mora perto da vítima?");
// string R3 = Console.ReadLine().ToLower();


// Console.WriteLine($"Devia para a vítima?");
// string R4 = Console.ReadLine().ToLower();


// Console.WriteLine($"Já trabalhou com a vítima?");
// string R5 = Console.ReadLine().ToLower();

// if(R1 == "s")
// {sim += 1;}

// if(R2 == "s")
// {sim += 1;}

// if(R3 == "s")
// {sim += 1;}

// if(R4 == "s")
// {sim += 1;}

// if(R5 == "s")
// {sim += 1;}


// if(sim == 2)
// {Console.WriteLine($"É Suspeito");
// }
// else if(sim == 3 || sim == 4)
// {Console.WriteLine($"É Cumplice");
// }
// else if (sim == 5)
// {Console.WriteLine($"É Culpado");
// }
// else {Console.WriteLine($"É Inocente");
// }















// EXERCICIO 5 -


Console.WriteLine($"escreva uma letra do alfabeto:");
string L = Console.ReadLine().ToLower();


if(L == "a" || L =="e" || L =="i" || L =="o" || L =="u")
{Console.WriteLine($"{L} É uma vogal");
}
else{Console.WriteLine($"{L} É uma consoante");
}