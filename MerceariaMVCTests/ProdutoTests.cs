using MerceariaMVC.Models;
using Microsoft.AspNetCore.Http.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace MerceariaMVCTests
{
    public class ProdutoTests
    {
        [Fact]
        public void Verificar_Preco_Invalido_seForMenorqueZero()
        {
            //Arrange 
            var produto = new Produto
            {
                Nome = "Pacote de Salada",
                Preco = 0,
                Estoque = 5000
            };

            //Act 

            var resultado = produto.Validacao();

            //Assert

            Assert.False(resultado);
        }

        [Fact]

        public void Estoque_Invalido_se_ValorMenorqueZerro()
        {
            //Arrange
            var produto = new Produto
            {
                Nome = "Muçarela",
                Preco = 45,
                Estoque = -1
            };

            //Act 
            var resultado = produto.Validacao();

            //Assert 
            Assert.False(resultado);
        }

        [Fact]
        public void Verificar_Nome_Nulo_ou_Vazio_Invalido()
        {
            //Arrange 
            var produto = new Produto
            {
                Nome = "",
                Preco = 50,
                Estoque = 45
            };

            //Act
            var resultdo = produto.Validacao();

            //Assert 
            Assert.False(resultdo);

        }

        [Fact]
        public void Verifica_PrecoMaiorqueZero_Estoque_MaiorqueZero_NomeProdutoExistente()
        {
            //Arrange
            var produto = new Produto
            {
                Nome = "Proteína Isolada",
                Preco = 115,
                Estoque = 50
            };

            //Act 
            var resultado = produto.Validacao();

            //Assert 
            Assert.True(resultado);

        }
    }
}
