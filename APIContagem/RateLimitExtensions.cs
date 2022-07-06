namespace APIContagem;

public static class RateLimitExtensions
{
    public static int Limit { get; } = 5;
    public static string Period { get; } = "10s";
    public static string QuotaExceededMessage { get; } =
        $"Limite de utilização atingido: {Limit} requisições a cada {Period}! Aguarde e tente novamente...";
}