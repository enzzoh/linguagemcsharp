

using Juridico.Models;
using System;
using Xunit;


namespace JuridicoTDD
{
    public class AdvogadoTDD
    {
        [Fact]
        public void AdvogadoretornarnomecompletoTRUE()
        {

            Advogado adv = new Advogado();

            adv.nome = "vinicius";
            adv.Sobrenome = "regis";
            string esperado = "vinicius regis";
            string resultado="";


            resultado = adv.Getnomecompleto();

         


            Assert.Equal(esperado, resultado);







        }
        [Theory]
        [InlineData("reginaldo", "grusguval","reginaldo grugusval")]
        [InlineData("jose","minecraft","Jose Minecraft")]
        public void advogadoretornanomecompletovarioscenarios(string nome, string sob, string esperado)
        {
            Advogado adv = new Advogado();
            adv.nome = nome;
            adv.Sobrenome = sob;

            string resultado = adv.Getnomecompleto();




            Assert.Equal(resultado, esperado);














        }
    }
}
