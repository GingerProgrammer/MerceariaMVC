using MerceariaMVC.Models;
using Microsoft.AspNetCore.Http.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerceariaMVCTests
{
    public class ClienteTeste
    {
        [Fact]
        public void Verificar_Nome_Nulo_ou_Vazio()
        {
            //Arrange 
            var cliente = new Cliente
            {
                Nome = "",
                Email = "mariana@gmail.com",
                Idade = 16,
                Ativo = true

            };

            //Act
            var resultado = cliente.Validacao();

            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void Verificar_Email_Valido()
        {
            //Arrange
            var cliente = new Cliente
            {
                Nome = "Mariana",
                Email = "marianagmail.com",
                Idade = 16,
                Ativo = true

            };

            //Act
            var resultado = cliente.Validacao();

            //Assert
            Assert.False(resultado);

        }

        [Fact]
        public void Verificar_Idade_Menor_Dezoito_Invalido()
        {
            //Arrange
            var cliente = new Cliente
            {
                Nome = "Mariana",
                Email = "mariana@gmail.com",
                Idade = 16,
                Ativo = true

            };

            //Act
            var resultado = cliente.Validacao();

            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void Verficar_Cliente_Ativo_ou_Inativo()
        {
            //Arrange
            var cliente = new Cliente
            {
                Nome = "Mariana",
                Email = "mariana@gmail.com",
                Idade = 16,
                Ativo = false
            };

            //Act 
            var resultado = cliente.Validacao();

            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void Verificar_Cliente_Apto_Maior_Dezoito()
        {
            //Arrange 
            var cliente = new Cliente
            {
                Nome = "Mariana",
                Email = "mariana@gmail.com",
                Idade = 16,
                Ativo = true
            };

            //Act 
            var resultado = cliente.Validacao();

            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void Verificar_Cliente_Apto_Maior_Dezoito_Valido()
        {
            //Arrange 
            var cliente = new Cliente
            {
                Nome = "Mariana",
                Email = "mariana@gmail.com",
                Idade = 20,
                Ativo = true
            };

            //Act
            var resultado = cliente.Validacao();

            //Assert
            Assert.True(resultado);


        }
    }     

}