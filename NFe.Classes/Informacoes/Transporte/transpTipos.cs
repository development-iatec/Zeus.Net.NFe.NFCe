﻿/********************************************************************************/
/* Projeto: Biblioteca ZeusNFe                                                  */
/* Biblioteca C# para emissão de Nota Fiscal Eletrônica - NFe e Nota Fiscal de  */
/* Consumidor Eletrônica - NFC-e (http://www.nfe.fazenda.gov.br)                */
/*                                                                              */
/* Direitos Autorais Reservados (c) 2014 Adenilton Batista da Silva             */
/*                                       Zeusdev Tecnologia LTDA ME             */
/*                                                                              */
/*  Você pode obter a última versão desse arquivo no GitHub                     */
/* localizado em https://github.com/adeniltonbs/Zeus.Net.NFe.NFCe               */
/*                                                                              */
/*                                                                              */
/*  Esta biblioteca é software livre; você pode redistribuí-la e/ou modificá-la */
/* sob os termos da Licença Pública Geral Menor do GNU conforme publicada pela  */
/* Free Software Foundation; tanto a versão 2.1 da Licença, ou (a seu critério) */
/* qualquer versão posterior.                                                   */
/*                                                                              */
/*  Esta biblioteca é distribuída na expectativa de que seja útil, porém, SEM   */
/* NENHUMA GARANTIA; nem mesmo a garantia implícita de COMERCIABILIDADE OU      */
/* ADEQUAÇÃO A UMA FINALIDADE ESPECÍFICA. Consulte a Licença Pública Geral Menor*/
/* do GNU para mais detalhes. (Arquivo LICENÇA.TXT ou LICENSE.TXT)              */
/*                                                                              */
/*  Você deve ter recebido uma cópia da Licença Pública Geral Menor do GNU junto*/
/* com esta biblioteca; se não, escreva para a Free Software Foundation, Inc.,  */
/* no endereço 59 Temple Street, Suite 330, Boston, MA 02111-1307 USA.          */
/* Você também pode obter uma copia da licença em:                              */
/* http://www.opensource.org/licenses/lgpl-license.php                          */
/*                                                                              */
/* Zeusdev Tecnologia LTDA ME - adenilton@zeusautomacao.com.br                  */
/* http://www.zeusautomacao.com.br/                                             */
/* Rua Comendador Francisco josé da Cunha, 111 - Itabaiana - SE - 49500-000     */
/********************************************************************************/

using System.Xml.Serialization;

namespace NFe.Classes.Informacoes.Transporte
{
    /// <summary>
    ///<para>0=Contratação do Frete por conta do Remetente(CIF);</para>
    ///<para>1=Contratação do Frete por conta do Destinatário(FOB);</para>
    ///<para>2=Contratação do Frete por conta de Terceiros;</para>
    ///<para>3=Transporte Próprio por conta do Remetente;</para>
    ///<para>4=Transporte Próprio por conta do Destinatário;</para>
    ///<para>9=Sem Ocorrência de Transporte.</para>
    /// </summary>
    public enum ModalidadeFrete
    {
        [XmlEnum("0")]
        Cif = 0,

        [XmlEnum("1")]
        Fob = 1,

        [XmlEnum("2")]
        Terceiros = 2,

        [XmlEnum("3")]
        Remetente = 3,

        [XmlEnum("4")]
        Destinatario = 4,

        [XmlEnum("9")]
        SemFrete = 9
    }
}