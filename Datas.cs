namespace Datas;

public class TrabalhandoComDatas
{
  public void AulaDateTime()
  {
    var data01 = new DateTime(2024, 10, 04, 23, 29, 00); // Informanda a data e hora completa, se preferir é possível informar só a data também 
    var data02 = DateTime.Parse("2024/10/04 23:31:30"); // Usando o Parse para converter para o formato DateTime
    var data03 = DateTime.Now; // Now = Data e hora de agora
    var data04 = DateTime.Today; // Today = Somente a data de agora

    Console.WriteLine(data01);
    Console.WriteLine(data02);
    Console.WriteLine(data03);
    Console.WriteLine(data04);

    Console.WriteLine(data01.ToString("dd=MM-yyyy HH:mm:ss")); // Formatando data e hora

    var data05 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0)); // Informando o deslocamento UTC de -03:00:00
    Console.WriteLine(data05.LocalDateTime); // Exibindo o horário local
    Console.WriteLine(data05.UtcDateTime); // Exibindo o horário com o deslocamento UTC informado
  }

  public void AulaSubtraindoDatas()
  {
    var data01 = DateTime.Now;
    var data02 = DateTime.Parse("2024-01-01");

    // Duas maneiras de fazer subtração de data com o mesmo resultado
    //var diferenca = data01 - data02; 
    var diferenca = data01.Subtract(data02);

    Console.WriteLine((int)diferenca.TotalDays); // Diferença do total de dias | int para converter o valor double para inteiro
    Console.WriteLine((int)diferenca.TotalHours); // Diferença do total de horas
  }

  public void AulaAdicionandoDiaMesAno()
  {
    var data01 = DateTime.Now;

    Console.WriteLine(data01.AddDays(3)); // Adicionando 3 dias sobre a data atual
    Console.WriteLine(data01.AddMonths(1)); // Adicionando 1 mês sobre a data atual
    Console.WriteLine(data01.AddYears(1)); // Adicionando 1 ano sobre a data atual
  }

  public void AulaAdicionandoHorasMinutosSegundos()
  {
    var data01 = DateTime.Now;

    Console.WriteLine(data01.AddHours(1).ToString("HH:mm:ss")); // Adicionando 1 hora sobre a data atual
    Console.WriteLine(data01.AddMinutes(10).ToString("HH:mm:ss")); // Adicionando 10 minutos sobre a data atual
    Console.WriteLine(data01.AddSeconds(10).ToString("HH:mm:ss")); // Adicionando 10 segundos sobre a data atual
  }

  public void AulaRecuperandoDiaDaSemana()
  {
    var data01 = DateTime.Now;

    Console.WriteLine(data01.DayOfWeek); // Verificando qual é o dia da semana
  }

  public void AulaDateOnly()
  {
    // Duas formas de usar o DateOnly
    var data01 = new DateOnly(2024, 10, 05); // DateOnly para trabalhar com somente as datas, sem utilizar as horas
    var data02 = DateOnly.Parse("2024-10-05");

    Console.WriteLine(data01);
    Console.WriteLine(data02);
  }

  public void AulaTimeOnly()
  {
    // Duas formas de usar o DateOnly
    var hora01 = new TimeOnly(02, 06, 15); // DateOnly para trabalhar com somente as horas, sem utilizar as datas
    var hora02 = TimeOnly.Parse("02:07:20");

    Console.WriteLine(hora01.ToString("HH:mm:ss"));
    Console.WriteLine(hora02.ToString("HH:mm:ss"));
  }
}