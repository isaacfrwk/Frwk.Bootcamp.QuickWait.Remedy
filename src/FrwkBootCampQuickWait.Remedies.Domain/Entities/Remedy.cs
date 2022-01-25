namespace Frwk.BootCamp.QuickWait.Remedies.Domain.Entities
{
    public sealed class Remedy : Entity
    {
        public string Nome { get; private set; }

        public Remedy(string nome)
        {
            Nome = nome;
        }
    }
}
