using AppMvcBasic.Models;
using AppMvcBasic.Test.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AppMvcBasic.Test.Models
{
    public class FornecedorTest
    {
        [Fact]
        public void Fornecedor_ShouldReturnSuccess_WhenPropertiesAreCorrect()
        {
            var model = new Fornecedor()
            {
                Nome = "Juan Pablo Escobar",
                Documento = "123456789",
                Ativo = true
            };

            var result = TestModelHelper.Validate(model);

            Assert.Equal(0, result.Count);
        }
    }
}
