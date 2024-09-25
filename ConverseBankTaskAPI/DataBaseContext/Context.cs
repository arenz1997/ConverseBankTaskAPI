using ConverseBankTaskAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Numerics;

namespace ConverseBankTaskAPI.DataBaseContext
{
    public partial class Context : DbContext
    {
        public Context()
        {
            Database.EnsureCreated();
        }
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DB1.AREGAK.LOCAL;initial catalog=zeppaClientsGate;persist security info=True;user id=acramon;password=2{sD6@.[SsF0[#jq;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework&quot;providerName=System.Data.EntityClient");
        }
        public virtual DbSet<OperationModel> Accounts { get; set; }
    }
}
