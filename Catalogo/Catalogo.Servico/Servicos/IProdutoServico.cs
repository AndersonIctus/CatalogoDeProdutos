using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Catalogo.Servico.Servicos
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IProdutoServico" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IProdutoServico
    {
        [OperationContract]
        void DoWork();
    }
}
