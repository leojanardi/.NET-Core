using System;
using Xunit;

namespace XUnit_NetCore.Domain.Test.Util
{
    public static class AssertExtension
    {
        public static void ValidarMensagem(this ArgumentException argumentException, string mensagemErro)
        {
            if (argumentException.Message == mensagemErro)
            {
                Assert.True(true);
            }
            else
            {
                Assert.False(true, $"A mensagem esperada é {mensagemErro}");
            }
        }
    }
}
