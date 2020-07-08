using System;
using ExpectedObjects;
using Xunit;
using XUnit_NetCore.Domain.Enums;
using XUnit_NetCore.Domain.Test.Util;

namespace XUnit_NetCore.Domain.Test.Cursos
{
    public class CursoTest
    {

        //[Fact(DisplayName = "CriacaoDoCurso")]
        //public void CriarCurso()
        //{
        //    var cursoEsperado = new
        //    {
        //        Nome = "Curso de C#",
        //        CargaHoraria = (double)40,
        //        PublicoAlvo = PublicoAlvo.Programador,
        //        Valor = (double)50
        //    };

        //    var curso = new Curso(cursoEsperado.Nome, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, cursoEsperado.Valor);

        //    cursoEsperado.ToExpectedObject().ShouldMatch(curso);
        //}

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Curso_NomeVazioOuNulo_RetornaArgumentException(string nomeInvalido)
        {
            var cursoEsperado = new
            {
                Nome = "Curso de C#",
                CargaHoraria = (double)40,
                PublicoAlvo = PublicoAlvo.Programador,
                Valor = (double)50
            };

            Assert.Throws<ArgumentException>(() => new Curso(nomeInvalido, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, cursoEsperado.Valor));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        public void Curso_CargaHorariaMenorQue1_RetornaArgumentException(double cargaHorariaInvalida)
        {
            string mensagemErro = "Parâmetros inválidos";
            var cursoEsperado = new
            {
                Nome = "Curso de C#",
                CargaHoraria = (double)40,
                PublicoAlvo = PublicoAlvo.Programador,
                Valor = (double)50
            };

            Assert.Throws<ArgumentException>(() => new Curso(cursoEsperado.Nome, cargaHorariaInvalida, cursoEsperado.PublicoAlvo, cursoEsperado.Valor)).ValidarMensagem(mensagemErro);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        public void Curso_ValorMenorQue1_RetornaArgumentException(double valorInvalido)
        {
            string mensagemErro = "Parâmetros inválidos";
            var cursoEsperado = new
            {
                Nome = "Curso de C#",
                CargaHoraria = (double)40,
                PublicoAlvo = PublicoAlvo.Programador,
                Valor = (double)50
            };

            Assert.Throws<ArgumentException>(() => new Curso(cursoEsperado.Nome, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, valorInvalido)).ValidarMensagem(mensagemErro);
        }
    }
}
